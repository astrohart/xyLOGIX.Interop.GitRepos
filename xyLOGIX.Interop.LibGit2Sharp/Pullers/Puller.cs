using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;

namespace xyLOGIX.Interop.LibGit2Sharp.Pullers
{
    /// <summary>
    /// Pulls changes from the remote to the local repository.
    /// </summary>
    public class Puller : RepositoryBoundObject, IPuller
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Puller() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Puller() { }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Pullers.Puller" />.
        /// </summary>
        public static Puller Instance { get; } = new Puller();

        /// <summary>
        /// Pulls the latest commits from the origin remote to the local repository's
        /// master branch.
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
        public void Pull()
        {
            if (Repository == null)
                throw new RepositoryNotAttachedException();

            ValidateConfiguration();

            OnPullStarted();

            try
            {
                // Credential information to fetch
                var options = new PullOptions
                {
                    FetchOptions = new FetchOptions
                    {
                        CredentialsProvider = (url, usernameFromUrl, types) =>
                            new UsernamePasswordCredentials
                            {
                                Username = GitHubUserName,
                                Password = GitHubPassword
                            }
                    }
                };

                // User information to create a merge commit
                var signature =
                    new Signature(GitHubName, GitHubEmail, DateTime.Now);

                // Pull
                Commands.Pull((Repository) Repository, signature, options);
            }
            catch (Exception ex)
            {
                OnPullFailed(new PullFailedEventArgs(ex));
            }

            OnPullCompleted();
        }

        /// <summary>
        /// Raised when a Pull operation has completed successfully.
        /// </summary>
        public event EventHandler PullCompleted;

        /// <summary>
        /// Raised when a Pull operation has failed.
        /// </summary>
        public event PullFailedEventHandler PullFailed;

        /// <summary>
        /// Raised when a Pull operation has started.
        /// </summary>
        public event EventHandler PullStarted;

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pullers.Puller.PullCompleted " />
        /// event.
        /// </summary>
        protected virtual void OnPullCompleted()
            => PullCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pullers.Puller.PullFailed " /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.PullFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnPullFailed(PullFailedEventArgs e)
            => PullFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pullers.Puller.PullStarted " />
        /// event.
        /// </summary>
        protected virtual void OnPullStarted()
            => PullStarted?.Invoke(this, EventArgs.Empty);
    }
}