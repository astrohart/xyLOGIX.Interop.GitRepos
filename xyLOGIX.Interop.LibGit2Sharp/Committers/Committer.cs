using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;

namespace xyLOGIX.Interop.LibGit2Sharp.Committers
{
    /// <summary>
    /// Commits staged items to a Git repository.
    /// </summary>
    public class Committer : RepositoryBoundObject, ICommitter
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Committer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Committer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Committers.Committer" />.
        /// </summary>
        public static Committer Instance { get; } = new Committer();

        /// <summary>
        /// Raised when a Commit operation has completed successfully.
        /// </summary>
        public event EventHandler CommitCompleted;

        /// <summary>
        /// Raised when a Commit operation has failed.
        /// </summary>
        public event CommitFailedEventHandler CommitFailed;

        /// <summary>
        /// Raised when a Commit operation has been started.
        /// </summary>
        public event EventHandler CommitStarted;

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
        public void Commit(string commitMessage, bool addTimestamp = false)
        {
            if (Repository == null)
                throw new RepositoryNotAttachedException();

            ValidateConfiguration();

            if (string.IsNullOrWhiteSpace(commitMessage))
                throw new InvalidOperationException(
                    "ERROR (Commit): commitMessage is a required parameter.");

            OnCommitStarted();

            try
            {
                // Create the committer's signature and commit
                var author = new Signature(GitHubName, GitHubEmail,
                    DateTime.Now);
                var committer = author;

                // Commit to the repository
                Repository.Commit(commitMessage, author, committer);
            }
            catch (Exception ex)
            {
                OnCommitFailed(new CommitFailedEventArgs(ex));
            }

            OnCommitCompleted();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.Git.Committers.Committer.CommitCompleted " />
        /// event.
        /// </summary>
        protected virtual void OnCommitCompleted()
            => CommitCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.Git.Committers.Committer.CommitFailed " />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.Git.Events.CommitFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnCommitFailed(
            CommitFailedEventArgs e)
            => CommitFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.Git.Committers.Committer.CommitStarted " /> event.
        /// </summary>
        protected virtual void OnCommitStarted()
            => CommitStarted?.Invoke(this, EventArgs.Empty);
    }
}