using LibGit2Sharp;
using PostSharp.Patterns.Diagnostics;
using System;
using System.IO;
using xyLOGIX.Interop.GitRepos.Actions.Exceptions;
using xyLOGIX.Interop.GitRepos.Actions.Stagers.Events;
using xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions.Stagers
{
    /// <summary>
    /// Stages changes in the working tree to a local Git repository.
    /// </summary>
    public class Stager : GitRepositoryAction, IStager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static Stager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected Stager() { }

        /// <summary>
        /// Raised when a Stage operation has completed successfully.
        /// </summary>
        public event EventHandler StageCompleted;

        /// <summary>
        /// Raised when a Stage operation has failed.
        /// </summary>
        public event StageFailedEventHandler StageFailed;

        /// <summary>
        /// Raised when a Stage operation has been started.
        /// </summary>
        public event EventHandler StageStarted;

        /// <summary>
        /// Gets a reference to the one and only instance of <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static IStager Instance { get; } = new Stager();

        /// <summary>
        /// Stages all pending changes in the repository.
        /// </summary>
        /// <returns>
        /// True if the stage operation succeeded; false otherwise.
        /// </returns>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the <see
        /// cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository"/>
        /// method has not been called.
        /// </exception>
        public bool StageAll()
        {
            if (GitRepository == null)
                throw new GitRepositoryNotAttachedException();

            OnStageStarted();

            try
            {
                Commands.Stage(
                    GitRepository, "*"
                );
            }
            catch (Exception ex)
            {
                OnStageFailed(new StageFailedEventArgs(ex));

                return false;
            }

            OnStageCompleted();

            return true;
        }

        /// <summary>
        /// Stages the specified <paramref name="file"/> to the repository.
        /// </summary>
        /// <param name="file">
        /// String containing the full or relative path (to the working
        /// directory) of the item to be staged.
        /// </param>
        /// <returns>
        /// True if the stage operation succeeded; false otherwise.
        /// </returns>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the <see
        /// cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository"/>
        /// method has not been called.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// The item to be staged, whose path is specified by the <paramref
        /// name="file"/> parameter, could not be located.
        /// </exception>
        public bool StageFile(string file)
        {
            if (GitRepository == null)
                throw new GitRepositoryNotAttachedException();

            Console.WriteLine($"Staging changes to '{file}' to local repo...");

            if (string.IsNullOrWhiteSpace(file)
                || file.Contains(":")
                && !File.Exists(file))
                throw new FileNotFoundException(
                    $"ERROR: AddFileToLocalRepo: The file '{file}' does not exist.");

            try
            {
                var repoFile = !file.Contains(":")
                    ? file
                    : StripRepoDirFromFilePath(file);
                if (string.IsNullOrWhiteSpace(repoFile))
                    return false;

                GitRepository.Index.Add(file);
                GitRepository.Index.Write();

                Console.WriteLine($"*** Staged file '{file}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"ERROR: Failed to stage file '{file}' to Git repository '{GitRepository.Info.WorkingDirectory}'.\r\n{ex.Message}\r\n\t{ex.StackTrace}");

                OnStageFailed(new StageFailedEventArgs(ex));

                return false;
            }

            OnStageCompleted();

            return true;
        }

        /// <summary>
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Stagers.Stager.StageCompleted "/> event.
        /// </summary>
        protected virtual void OnStageCompleted()
            => StageCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Stagers.Stager.StageFailed "/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:xyLOGIX.Interop.GitRepos.Events.StageFailedEventArgs"/> that
        /// contains the event data.
        /// </param>
        protected virtual void OnStageFailed(StageFailedEventArgs e)
            => StageFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Stagers.Stager.StageStarted "/> event.
        /// </summary>
        protected virtual void OnStageStarted()
            => StageStarted?.Invoke(this, EventArgs.Empty);
    }
}