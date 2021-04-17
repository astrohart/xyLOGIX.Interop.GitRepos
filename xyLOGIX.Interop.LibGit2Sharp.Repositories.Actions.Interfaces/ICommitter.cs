using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Committer object.
    /// </summary>
    public interface ICommitter : IGitRepositoryAction
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
        /// commit message.
        /// </param>
        /// <remarks>
        /// Use two
        /// newline characters, '\n\n', in the message to separate the short commit message
        /// from a detailed commit message.
        /// </remarks>
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
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the <paramref name="commitMessage" /> is blank for a repository where
        /// it is configured to be mandatory.
        /// </exception>
        void Commit(string commitMessage, bool addTimestamp = false);
    }
}