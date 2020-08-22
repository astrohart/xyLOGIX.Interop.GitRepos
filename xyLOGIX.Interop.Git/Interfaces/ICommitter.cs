using System;
using xyLOGIX.Interop.Git.Events;

namespace xyLOGIX.Interop.Git.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Committer object.
    /// </summary>
    public interface ICommitter
    {
        /// <summary>
        /// Occurs when a Commit operation has been started.
        /// </summary>
        event EventHandler CommitStarted;

        /// <summary>
        /// Creates a commit with the specified <paramref name="commitMessage" />.
        /// </summary>
        /// <param name="commitMessage">(Required.)String containing the commit message.</param>
        /// <param name="addTimestamp">(Optional.) Set to true to add the timestamp to the commit message.</param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required commit
        /// message is blank.
        /// </exception>
        void Commit(string commitMessage, bool addTimestamp = false);

        /// <summary>
        /// Occurs when a Commit operation has completed successfully.
        /// </summary>
        event EventHandler CommitCompleted;

        /// <summary>
        /// Occurs when a Commit operation has failed.
        /// </summary>
        event CommitFailedEventHandler CommitFailed;
    }
}