using Alphaleonis.Win32.Filesystem;
using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Extensions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Validators;

namespace xyLOGIX.Interop.LibGit2Sharp.Internal
{
    /// <summary>
    /// Defines methods and properties that are common to all repository-bound objects.
    /// </summary>
    public abstract class RepositoryContext : IRepositoryContext
    {
        /// <summary>
        /// Raised when a new Repository is attached to this object.
        /// </summary>
        public event RepositoryAttachedEventHandler RepositoryAttached;

        /// <summary>
        /// Raised when a repository is detached from this object.
        /// </summary>
        public event EventHandler RepositoryDetached;

        /// <summary>
        /// Gets or sets a reference to an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface that this object is
        /// currently working with.
        /// </summary>
        protected IRepository Repository { get; set; }

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
        public virtual void AttachRepository(IRepository repository)
        {
            Repository = repository ??
                         throw new ArgumentNullException(nameof(repository));
            OnRepositoryAttached(new RepositoryAttachedEventArgs(repository));
        }

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        public virtual void DetachRepository()
            => Repository = null;

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Changes.Stager.RepositoryAttached" />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.RepositoryAttachedEventArgs" />
        /// that
        /// contains the event data.
        /// </param>
        protected virtual void OnRepositoryAttached(
            RepositoryAttachedEventArgs e)
            => RepositoryAttached?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.LibGit2Sharp.Changes.Stager.RepositoryDetached.RepositoryDetached" />
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
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if the repository does not have a valid object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryConfiguration" />
        /// interface associated with it.
        /// </exception>
        protected void ValidateConfiguration()
        {
            var repositoryConfiguration = Repository.GetConfiguration();

            if (repositoryConfiguration == null
                || !RepositoryConfigurationValidator.IsValid(
                    repositoryConfiguration))
                throw new RepositoryNotConfiguredException();
        }
    }
}