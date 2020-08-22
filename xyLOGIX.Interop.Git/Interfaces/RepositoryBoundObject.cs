using LibGit2Sharp;
using System;
using xyLOGIX.Interop.Git.Events;

namespace xyLOGIX.Interop.Git.Interfaces
{
    /// <summary>
    /// Defines methods and properties that are common to all repository-bound objects.
    /// </summary>
    public abstract class RepositoryBoundObject : IRepositoryBoundObject
    {
        /// <summary>
        /// Occurs when a new Repository is attached to this object.
        /// </summary>
        public event RepositoryAttachedEventHandler RepositoryAttached;

        /// <summary>
        /// Occurs when a repository is detached from this object.
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
    }
}