using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Pushers
{
    /// <summary>
    /// Pushes commits to a remote.
    /// </summary>
    public class Pusher : GitRepositoryAction, IPusher
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Pusher() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Pusher() { }

        /// <summary>
        /// Raised when a Push operation has been completed.
        /// </summary>
        public event EventHandler PushCompleted;

        /// <summary>
        /// Raised when a Push operation fails.
        /// </summary>
        public event PushFailedEventHandler PushFailed;

        /// <summary>
        /// Raised when a Push operation is started.
        /// </summary>
        public event EventHandler PushStarted;

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Pushers.Pusher" />.
        /// </summary>
        public static Pusher Instance { get; } = new Pusher();

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
        public void Push()
        {
            if (GitRepository == null)
                throw new GitRepositoryNotAttachedException();

            ValidateConfiguration();

            var repositoryConfiguration = GitRepository.GetConfiguration();

            OnPushStarted();

            try
            {
                var remote =
                    GitRepository.Network.Remotes[
                        repositoryConfiguration.RemoteName];

                var options = new PushOptions
                {
                    CredentialsProvider = (_url, _user, _cred) =>
                        new UsernamePasswordCredentials
                        {
                            Username = repositoryConfiguration.RemoteUserName,
                            Password = repositoryConfiguration.RemotePassword
                        }
                };
                GitRepository.Network.Push(remote, @"refs/heads/master",
                    options);
            }
            catch (Exception ex)
            {
                OnPushFailed(new PushFailedEventArgs(ex));
            }

            OnPushCompleted();
        }

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pushers.Pusher.PushCompleted " />
        /// event.
        /// </summary>
        protected virtual void OnPushCompleted()
            => PushCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pushers.Pusher.PushFailed " /> event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.PushFailedEventArgs" /> that
        /// contains the event data.
        /// </param>
        protected virtual void OnPushFailed(PushFailedEventArgs e)
            => PushFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see cref="E:xyLOGIX.Interop.LibGit2Sharp.Pushers.Pusher.PushStarted " />
        /// event.
        /// </summary>
        protected virtual void OnPushStarted()
            => PushStarted?.Invoke(this, EventArgs.Empty);
    }
}