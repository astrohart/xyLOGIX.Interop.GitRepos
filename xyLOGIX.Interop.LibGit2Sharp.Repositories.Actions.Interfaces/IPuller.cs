using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
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
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown
        /// if the repository currently in use does not have a valid configuration
        /// associated with it.
        /// </exception>
        void Pull();
    }
}