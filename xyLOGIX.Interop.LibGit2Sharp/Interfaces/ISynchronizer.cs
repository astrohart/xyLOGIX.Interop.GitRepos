using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines methods and properties for a Synchronizer object.
    /// </summary>
    public interface ISynchronizer : IGitRepositoryContext
    {
        /// <summary>
        /// Raised when a Synchronization operation has completed.
        /// </summary>
        event EventHandler SynchronizationCompleted;

        /// <summary>
        /// Raised when a Synchronization operation has failed.
        /// </summary>
        event SynchronizationFailedEventHandler SynchronizationFailed;

        /// <summary>
        /// Raised when the Synchronization operation has started.
        /// </summary>
        event EventHandler SynchronizationStarted;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="xyLOGIX.Interop.LibGit2Sharp.Interfaces.IPuller" /> interface.
        /// </summary>
        IPuller Puller { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="xyLOGIX.Interop.LibGit2Sharp.Interfaces.IPusher" /> interface.
        /// </summary>
        IPusher Pusher { get; }

        /// <summary>
        /// Synchronizes (i.e., pulls, then pushes) the latest commits from the origin
        /// remote to the local repository's master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryContext.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid configuration
        /// associated with it.
        /// </exception>
        void Sync();
    }
}