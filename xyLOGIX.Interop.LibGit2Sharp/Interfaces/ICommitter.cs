using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Committer object.
    /// </summary>
    public interface ICommitter
    {
        /// <summary>
        /// Raised when a Commit operation has completed successfully.
        /// </summary>
        event EventHandler CommitCompleted;

        /// <summary>
        /// Raised when a Commit operation has failed.
        /// </summary>
        event CommitFailedEventHandler CommitFailed;

        /// <summary>
        /// Raised when a Commit operation has been started.
        /// </summary>
        event EventHandler CommitStarted;

        /// <summary>
        /// Creates a commit with the specified <paramref name="commitMessage" />.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two
        /// newline characters, '\n\n', in the message to separate the short commit message
        /// from a detailed commit message.
        /// </remarks>
        void Commit(string commitMessage, bool addTimestamp = false);
    }
}