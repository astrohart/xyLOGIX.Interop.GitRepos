using LibGit2Sharp;
using System;
using System.IO;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;
using File = Alphaleonis.Win32.Filesystem.File;

namespace xyLOGIX.Interop.LibGit2Sharp.Stagers
{
    /// <summary>
    /// Stages changes in the working tree to a local Git repository.
    /// </summary>
    public class Stager : RepositoryBoundObject, IStager
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Stager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Stager()
        {
            Repository =
                null; // initialize this object as unattached by default
        }

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
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Stagers.Stager" />.
        /// </summary>
        public static Stager Instance { get; } = new Stager();

        /// <summary>
        /// Stages all pending changes in the repository.
        /// </summary>
        /// <returns>True if the stage operation succeeded; false otherwise.</returns>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called prior to calling this method.
        /// </exception>
        public bool StageAll()
        {
            if (Repository == null)
                throw new RepositoryNotAttachedException();

            OnStageStarted();

            try
            {
                Commands.Stage(
                    Repository, "*"
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
        /// Stages the specified <paramref name="file" /> to the repository.
        /// </summary>
        /// <param name="file">
        /// String containing the full or relative path (to the working
        /// directory) of the item to be staged.
        /// </param>
        /// <returns>True if the stage operation succeeded; false otherwise.</returns>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called prior to calling this method.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// The item to be staged,
        /// whose path is specified by the <paramref name="file" /> parameter, could not be
        /// located.
        /// </exception>
        public bool StageFile(string file)
        {
            if (Repository == null)
                throw new RepositoryNotAttachedException();

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

                Repository.Index.Add(file);
                Repository.Index.Write();

                Console.WriteLine($"*** Staged file '{file}' successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(
                    $"ERROR: Failed to stage file '{file}' to Git repository '{Repository.Info.WorkingDirectory}'.\r\n{ex.Message}\r\n\t{ex.StackTrace}");

                OnStageFailed(new StageFailedEventArgs(ex));

                return false;
            }

            OnStageCompleted();

            return true;
        }

        /// <summary>
        /// Raises the <see cref="E:xyLOGIX.Interop.Git.Stagers.Stager.StageCompleted " />
        /// event.
        /// </summary>
        protected virtual void OnStageCompleted()
            => StageCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="E:xyLOGIX.Interop.Git.Stagers.Stager.StageFailed " />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.Git.Events.StageFailedEventArgs" /> that contains
        /// the event data.
        /// </param>
        protected virtual void OnStageFailed(StageFailedEventArgs e)
            => StageFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="E:xyLOGIX.Interop.Git.Stagers.Stager.StageStarted " />
        /// event.
        /// </summary>
        protected virtual void OnStageStarted()
            => StageStarted?.Invoke(this, EventArgs.Empty);
    }
}