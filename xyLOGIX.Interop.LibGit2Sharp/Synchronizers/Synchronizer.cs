using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Synchronizers
{
    /// <summary>
    /// Synchronizes a Git local repository with a remote.
    /// </summary>
    public sealed class Synchronizer : GitRepositoryAction, ISynchronizer
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Synchronizer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        private Synchronizer() { }

        /// <summary>
        /// Raised when a Synchronization operation has completed.
        /// </summary>
        public event EventHandler SynchronizationCompleted;

        /// <summary>
        /// Raised when a Synchronization operation has failed.
        /// </summary>
        public event SynchronizationFailedEventHandler SynchronizationFailed;

        /// <summary>
        /// Raised when the Synchronization operation has started.
        /// </summary>
        public event EventHandler SynchronizationStarted;

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Synchronizers.Synchronizer" />.
        /// </summary>
        public static Synchronizer Instance { get; } = new Synchronizer();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="IPuller" /> interface.
        /// </summary>
        public IPuller Puller { get; } = Pullers.Puller.Instance;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="IPusher" /> interface.
        /// </summary>
        public IPusher Pusher { get; } = Pushers.Pusher.Instance;

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IGitRepository" /> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IGitRepository" /> interface that is to be attached
        /// to this object.
        /// </param>
        /// <remarks>
        /// A repository object must be attached to this object object prior to
        /// use.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the
        /// <paramref name="repository" /> parameter is blank.
        /// </exception>
        public override void AttachGitRepository(IRepository repository)
        {
            Pusher.AttachGitRepository(repository);
            Puller.AttachGitRepository(repository);

            base.AttachGitRepository(repository);
        }

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        public override void DetachGitRepository()
        {
            Puller.DetachGitRepository();
            Pusher.DetachGitRepository();

            base.DetachGitRepository();
        }

        /// <summary>
        /// Synchronizes (i.e., pulls, then pushes) the latest commits from the origin
        /// remote to the local repository's master branch.
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
        /// Thrown if the repository currently in use does not have a valid configuration
        /// associated with it.
        /// </exception>
        public void Sync()
        {
            if (GitRepository == null)
                throw new GitRepositoryNotAttachedException();

            ValidateConfiguration();

            OnSynchronizationStarted();

            try
            {
                Puller.Pull();
                Pusher.Push();
            }
            catch (Exception ex)
            {
                OnSynchronizationFailed(new SynchronizationFailedEventArgs(ex));
            }

            OnSynchronizationCompleted();
        }

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.LibGit2Sharp.Synchronizers.Synchronizer.SynchronizationCompleted " />
        /// event.
        /// </summary>
        private void OnSynchronizationCompleted()
            => SynchronizationCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.LibGit2Sharp.Synchronizers.Synchronizer.SynchronizationFailed " />
        /// event.
        /// </summary>
        /// <param name="e">
        /// A
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.SynchronizationFailedEventArgs" />
        /// that contains the event data.
        /// </param>
        private void OnSynchronizationFailed(
            SynchronizationFailedEventArgs e)
            => SynchronizationFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the
        /// <see
        ///     cref="E:xyLOGIX.Interop.LibGit2Sharp.Synchronizers.Synchronizer.SynchronizationStarted " />
        /// event.
        /// </summary>
        private void OnSynchronizationStarted()
            => SynchronizationStarted?.Invoke(this, EventArgs.Empty);
    }
}