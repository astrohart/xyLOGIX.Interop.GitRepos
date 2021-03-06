using LibGit2Sharp;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Interop.GitRepos.Configuration.Helpers;
using xyLOGIX.Interop.GitRepos.Actions.Committers.Events;
using xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Exceptions;

namespace xyLOGIX.Interop.GitRepos.Actions.Committers
{
    /// <summary>
    /// Commits staged items to a Git repository.
    /// </summary>
    public class Committer : GitRepositoryAction, ICommitter
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static Committer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        protected Committer() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Committers.Committer" />
        /// .
        /// </summary>
        [Log(AttributeExclude = true)]
        public static ICommitter Instance { get; } = new Committer();

        /// <summary>
        /// Gets a timestamp string for commits. The string shows the local date
        /// and time in UTC.
        /// </summary>
        /// <returns>
        /// String containing the timestamp.
        /// </returns>
        private static string TheTimestamp
            => $"\n\nOperation completed at {DateTime.UtcNow.ToShortTimeString()} on {DateTime.UtcNow.ToShortDateString()} UTC.";

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
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the
        /// short commit message from a detailed commit message.
        /// </remarks>
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
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the <paramref name="commitMessage" /> is blank for a
        /// repository where it is configured to be mandatory.
        /// </exception>
        public void Commit(string commitMessage, bool addTimestamp = false)
        {
            if (GitRepository == null)
                throw new GitRepositoryNotAttachedException();

            ValidateConfiguration();

            var repositoryConfiguration = GitRepository.GetConfiguration();
            if (repositoryConfiguration.IsCommitMessageMandatory &&
                string.IsNullOrWhiteSpace(commitMessage))
                throw new InvalidOperationException(
                    "ERROR (Commit): commitMessage is a required parameter."
                );

            OnCommitStarted();

            try
            {
                // Create the committer's signature and commit
                var author = new Signature(
                    repositoryConfiguration.Name, repositoryConfiguration.Email,
                    DateTime.UtcNow
                );
                var committer = author;

                // Commit to the repository
                GitRepository.Commit(
                    commitMessage +
                    (addTimestamp ? TheTimestamp : string.Empty), author,
                    committer
                );
            }
            catch (Exception ex)
            {
                OnCommitFailed(new CommitFailedEventArgs(ex));
            }

            OnCommitCompleted();
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.GitRepos.Committers.Committer.CommitCompleted
        /// " />
        /// event.
        /// </summary>
        protected virtual void OnCommitCompleted()
            => CommitCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.GitRepos.Committers.Committer.CommitFailed
        /// " />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Events.CommitFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        protected virtual void OnCommitFailed(CommitFailedEventArgs e)
            => CommitFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.GitRepos.Committers.Committer.CommitStarted
        /// " />
        /// event.
        /// </summary>
        protected virtual void OnCommitStarted()
            => CommitStarted?.Invoke(this, EventArgs.Empty);
    }
}