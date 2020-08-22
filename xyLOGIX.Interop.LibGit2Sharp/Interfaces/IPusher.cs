using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines methods and properties for a Pusher.
    /// </summary>
    /// <remarks>Pusher objects push commits to a remote.</remarks>
    public interface IPusher
    {
        /// <summary>
        /// Occurs when a Push operation has been completed.
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
        ///     cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubUserName" />
        /// , or
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubPassword" />
        /// are blank.
        /// properties are blank.
        /// </exception>
        void Push();
    }
}