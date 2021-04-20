using System;
using xyLOGIX.Interop.GitRepos.Repositories.Actions.Interfaces;
using xyLOGIX.Interop.GitRepos.Repositories.Actions.Pullers.Events;

namespace xyLOGIX.Interop.GitRepos.Repositories.Actions.Pullers.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Puller.
    /// </summary>
    public interface IPuller : IGitRepositoryAction
    {
        /// <summary>
        /// Raised when a Pull operation has completed successfully.
        /// </summary>
        event EventHandler PullCompleted;

        /// <summary>
        /// Raised when a Pull operation has failed.
        /// </summary>
        event PullFailedEventHandler PullFailed;

        /// <summary>
        /// Raised when a Pull operation has started.
        /// </summary>
        event EventHandler PullStarted;

        /// <summary>
        /// Pulls the latest commits from the origin remote to the local repository's
        /// master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown
        /// if the repository currently in use does not have a valid configuration
        /// associated with it.
        /// </exception>
        void Pull();
    }
}