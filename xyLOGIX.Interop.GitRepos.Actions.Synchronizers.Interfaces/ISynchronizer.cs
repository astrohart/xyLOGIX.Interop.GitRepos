using System;
using xyLOGIX.Interop.GitRepos.Actions.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events;

namespace xyLOGIX.Interop.GitRepos.Actions.Synchronizers.
    Interfaces
{
    /// <summary>
    /// Defines methods and properties for a Synchronizer object.
    /// </summary>
    public interface ISynchronizer : IGitRepositoryAction
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
        /// Pulls the latest commits from the origin remote to the local
        /// repository's master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
        /// </exception>
        void Pull();

        /// <summary>
        /// Pushes commits from the master branch to a remote called origin.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
        /// </exception>
        void Push();

        /// <summary>
        /// Synchronizes (i.e., pulls, then pushes) the latest commits from the
        /// origin remote to the local repository's master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
        /// </exception>
        void Sync();
    }
}