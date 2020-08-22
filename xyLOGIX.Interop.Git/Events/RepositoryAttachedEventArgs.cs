using LibGit2Sharp;
using System;

namespace xyLOGIX.Interop.Git.Events
{
    /// <summary>
    /// Contains the data for a RepositoryAttached event.
    /// </summary>
    public class RepositoryAttachedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.Git.Events.RepositoryAttachedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="repository">
        /// Reference to the instance of the object that
        /// implements the <see cref="T:LibGit2Sharp.IRepository" /> interface to which the
        /// sending object has just been attached.
        /// </param>
        public RepositoryAttachedEventArgs(IRepository repository)
        {
            Repository = repository;
        }

        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface to which the sending object
        /// has just been attached.
        /// </summary>
        public IRepository Repository { get; }
    }
}