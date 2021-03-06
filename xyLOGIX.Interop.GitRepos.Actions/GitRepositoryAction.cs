using Alphaleonis.Win32.Filesystem;
using LibGit2Sharp;
using System;
using xyLOGIX.Interop.GitRepos.Configuration.Helpers;
using xyLOGIX.Interop.GitRepos.Configuration.Validators;
using xyLOGIX.Interop.GitRepos.Actions.Events;
using xyLOGIX.Interop.GitRepos.Actions.Exceptions;
using xyLOGIX.Interop.GitRepos.Actions.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions
{
    /// <summary>
    /// Defines methods and properties that are common to all repository-bound objects.
    /// </summary>
    /// <remarks>
    /// A repository-bound object is defined as an object that is responsible
    /// for performing actions, such as Commit, Push, Pull, Synchronize, Stage
    /// etc., on a repository's items.
    /// </remarks>
    public abstract class GitRepositoryAction : IGitRepositoryAction
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction" />
        /// and returns a reference to it.
        /// </summary>
        protected GitRepositoryAction()

            // Initialize this class as not attached to a Git repo by default.
            => GitRepository = null;

        /// <summary>
        /// Gets or sets a reference to an object that implements the
        /// <see
        ///     cref="T:LibGit2Sharp.IGitRepository" />
        /// interface that this object is
        /// currently working with.
        /// </summary>
        protected IRepository GitRepository { get; set; }

        /// <summary>
        /// Raised when a new GitRepository is attached to this object.
        /// </summary>
        public event GitRepositoryAttachedEventHandler GitRepositoryAttached;

        /// <summary>
        /// Raised when a repository is detached from this object.
        /// </summary>
        public event EventHandler GitRepositoryDetached;

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see
        ///     cref="T:LibGit2Sharp.IGitRepository" />
        /// interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:LibGit2Sharp.IGitRepository" />
        /// interface that is to be
        /// attached to this object.
        /// </param>
        /// <remarks>
        /// A repository object must be attached to this object object prior to use.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the <paramref name="repository" /> parameter is blank.
        /// </exception>
        public virtual void AttachGitRepository(IRepository repository)
        {
            GitRepository = repository ??
                            throw new ArgumentNullException(nameof(repository));
            OnGitRepositoryAttached(
                new GitRepositoryAttachedEventArgs(repository)
            );
        }

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        public virtual void DetachGitRepository()
            => GitRepository = null;

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.GitRepos.Changes.Stager.GitRepositoryAttached" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Events.GitRepositoryAttachedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnGitRepositoryAttached(
            GitRepositoryAttachedEventArgs e)
            => GitRepositoryAttached?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.GitRepos.Changes.Stager.GitRepositoryDetached.GitRepositoryDetached" />
        /// event.
        /// </summary>
        protected virtual void OnGitRepositoryDetached()
            => GitRepositoryDetached?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Strips the repository's working directory path from a full pathname,
        /// making it relative to the tree root.
        /// </summary>
        /// <param name="path">
        /// String containing the full path and filename of a repository item.
        /// </param>
        /// <returns>
        /// Path of the item, relative to the working tree root, or the empty
        /// string if an error occurred.
        /// </returns>
        /// <remarks>
        /// If the required parameter, <paramref name="path" />, is a blank
        /// string or refers to the pathname of a file that does not exist, or
        /// if the
        /// <see
        ///     cref="P:xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.GitRepository" />
        /// property has a <see langword="null" /> value, then this method does
        /// nothing and returns the blank string as the result.
        /// </remarks>
        protected string StripRepoDirFromFilePath(string path)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(path) || !File.Exists(path) ||
                    GitRepository == null)
                    return result;

                var repoWorkingDir = GitRepository.Info.WorkingDirectory;
                if (!path.StartsWith(repoWorkingDir))
                    return result;

                if (!Directory.Exists(repoWorkingDir))
                    return result;

                // replace up to the backslash
                result = path.Replace(
                    repoWorkingDir.EndsWith(@"\")
                        ? repoWorkingDir
                        : repoWorkingDir + @"\", string.Empty
                );
            }
            catch
            {
                result = string.Empty;
            }

            return result;
        }

        /// <summary>
        /// Determine whether the configuration is set up.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository does not have a valid object that
        /// implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration" />
        /// interface associated with it.
        /// </exception>
        protected void ValidateConfiguration()
        {
            var repositoryConfiguration = GitRepository.GetConfiguration();

            if (repositoryConfiguration == null ||
                !GitRepositoryConfigurationValidator.IsValid(
                    repositoryConfiguration
                ))
                throw new GitRepositoryNotConfiguredException();
        }
    }
}