using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Exceptions;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;

namespace xyLOGIX.Interop.LibGit2Sharp.Synchronizers
{
    /// <summary>
    /// Synchronizes a Git local repository with a remote.
    /// </summary>
    public sealed class Synchronizer : RepositoryBoundObject, ISynchronizer
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
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Synchronizers.Synchronizer" />.
        /// </summary>
        public static Synchronizer Instance { get; } = new Synchronizer();

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
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="xyLOGIX.Interop.LibGit2Sharp.Interfaces.IPuller" /> interface.
        /// </summary>
        public IPuller Puller { get; } = Pullers.Puller.Instance;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="xyLOGIX.Interop.LibGit2Sharp.Interfaces.IPusher" /> interface.
        /// </summary>
        public IPusher Pusher { get; } = Pushers.Pusher.Instance;

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IRepository" /> interface that is to be attached
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
        public override void AttachRepository(IRepository repository)
        {
            Pusher.AttachRepository(repository);
            Puller.AttachRepository(repository);

            base.AttachRepository(repository);
        }

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        public override void DetachRepository()
        {
            Puller.DetachRepository();
            Pusher.DetachRepository();

            base.DetachRepository();
        }

        /// <summary>
        /// Synchronizes (i.e., pulls, then pushes) the latest commits from the origin
        /// remote to the local repository's master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
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
        public void Sync()
        {
            if (Repository == null)
                throw new RepositoryNotAttachedException();

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