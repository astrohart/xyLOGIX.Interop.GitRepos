using Alphaleonis.Win32.Filesystem;
using LibGit2Sharp;
using System;
using xyLOGIX.Interop.Git.Events;
using xyLOGIX.Interop.Git.Exceptions;
using xyLOGIX.Interop.Git.Interfaces;

namespace xyLOGIX.Interop.Git.Internal
{
    /// <summary>
    /// Defines methods and properties that are common to all repository-bound objects.
    /// </summary>
    public abstract class RepositoryBoundObject : IRepositoryBoundObject
    {
        /// <summary>
        /// Gets or sets a reference to an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface that this object is
        /// currently working with.
        /// </summary>
        protected IRepository Repository { get; set; }

        /// <summary>
        /// Occurs when a new Repository is attached to this object.
        /// </summary>
        public event RepositoryAttachedEventHandler RepositoryAttached;

        /// <summary>
        /// Occurs when a repository is detached from this object.
        /// </summary>
        public event EventHandler RepositoryDetached;

        /// <summary>
        /// Gets or sets the email address and/or social media POC to utilize for
        /// operations.
        /// </summary>
        public string GitHubEmail { get; set; }

        /// <summary>
        /// Gets or sets the name to be utilized for operations.
        /// </summary>
        public string GitHubName { get; set; }

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IRepository" /> interface that is to be attached
        /// to this object.
        /// </param>
        /// <remarks>
        /// A repository object must be attached to this object object prior to
        /// use.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the
        /// <paramref name="repository" /> parameter is blank.
        /// </exception>
        public void AttachRepository(IRepository repository)
        {
            Repository = repository ??
                         throw new ArgumentNullException(nameof(repository));
            OnRepositoryAttached(new RepositoryAttachedEventArgs(repository));
        }

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        public void DetachRepository()
            => Repository = null;

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.Git.Changes.Stager.RepositoryAttached" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.Git.Events.RepositoryAttachedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnRepositoryAttached(
            RepositoryAttachedEventArgs e)
            => RepositoryAttached?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.Git.Changes.Stager.RepositoryDetached.RepositoryDetached" />
        /// event.
        /// </summary>
        protected virtual void OnRepositoryDetached()
            => RepositoryDetached?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Strips the repository's working directory path from a full pathname, making it
        /// relative to the tree root.
        /// </summary>
        /// <param name="path">
        /// String containing the full path and filename of a repository
        /// item.
        /// </param>
        /// <returns>
        /// Path of the item, relative to the working tree root, or the empty
        /// string if an error occurred.
        /// </returns>
        protected string StripRepoDirFromFilePath(string path)
        {
            var result = string.Empty;

            try
            {
                if (string.IsNullOrWhiteSpace(path)
                    || !File.Exists(path)
                    || Repository == null)
                    return result;

                var repoWorkingDir = Repository.Info.WorkingDirectory;
                if (!path.StartsWith(repoWorkingDir))
                    return result;

                if (!Directory.Exists(repoWorkingDir))
                    return result;

                // replace up to the backslash
                result =
                    path.Replace(
                        repoWorkingDir.EndsWith(@"\")
                            ? repoWorkingDir
                            : repoWorkingDir + @"\", string.Empty);
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
        ///     cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        protected void ValidateConfiguration()
        {
            if (string.IsNullOrWhiteSpace(GitHubName)
                || string.IsNullOrWhiteSpace(GitHubEmail))
            throw new RepositoryNotConfiguredException();
        }
    }
}