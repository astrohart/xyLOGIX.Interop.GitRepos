using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Pushers.Interfaces
{
    /// <summary>
    /// Defines methods and properties for a Pusher.
    /// </summary>
    /// <remarks>Pusher objects push commits to a remote.</remarks>
    public interface IPusher : IGitRepositoryAction
    {
        /// <summary>
        /// Raised when a Push operation has been completed.
        /// </summary>
        event EventHandler PushCompleted;

        /// <summary>
        /// Raised when a Push operation fails.
        /// </summary>
        event PushFailedEventHandler PushFailed;

        /// <summary>
        /// Raised when a Push operation is started.
        /// </summary>
        event EventHandler PushStarted;

        /// <summary>
        /// Pushes commits from the master branch to a remote called origin.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown
        /// if the repository currently in use does not have a valid configuration
        /// associated with it.
        /// </exception>
        void Push();
    }
}