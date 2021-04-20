using LibGit2Sharp;
using System;

namespace xyLOGIX.Interop.GitRepos.Repositories.Actions.Events
{
    /// <summary>
    /// Contains the data for a GitRepositoryAttached event.
    /// </summary>
    public class GitRepositoryAttachedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.GitRepos.Events.GitRepositoryAttachedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="repository">
        /// Reference to the instance of the object that
        /// implements the <see cref="T:LibGit2Sharp.IGitRepository" /> interface to which the
        /// sending object has just been attached.
        /// </param>
        public GitRepositoryAttachedEventArgs(IRepository repository)
        {
            GitRepository = repository;
        }

        /// <summary>
        /// Gets a reference to the instance of the object that implements the
        /// <see cref="T:LibGit2Sharp.IGitRepository" /> interface to which the sending object
        /// has just been attached.
        /// </summary>
        public IRepository GitRepository { get; }
    }
}