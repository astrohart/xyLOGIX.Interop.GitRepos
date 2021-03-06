using LibGit2Sharp;
using PostSharp.Patterns.Diagnostics;
using System;
using xyLOGIX.Interop.GitRepos.Actions.Exceptions;
using xyLOGIX.Interop.GitRepos.Actions.Pullers.Factories;
using xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Pushers.Factories;
using xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces;
using xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events;
using xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions.Synchronizers
{
    /// <summary>
    /// Synchronizes a Git local repository with a remote.
    /// </summary>
    public sealed class Synchronizer : GitRepositoryAction, ISynchronizer
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
        static Synchronizer() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        [Log(AttributeExclude = true)]
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
        /// Gets a reference to the one and only instance of <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer"/>.
        /// </summary>
        [Log(AttributeExclude = true)]
        public static Synchronizer Instance { get; } = new Synchronizer();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="IPuller"/> interface.
        /// </summary>
        private IPuller Puller { get; } = GetPuller.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="IPusher"/> interface.
        /// </summary>
        private IPusher Pusher { get; } = GetPusher.SoleInstance();

        /// <summary>
        /// Attaches an instance of an object that implements the <see
        /// cref="T:LibGit2Sharp.IGitRepository"/> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements the <see
        /// cref="T:LibGit2Sharp.IGitRepository"/> interface that is to be
        /// attached to this object.
        /// </param>
        /// <remarks>
        /// A repository object must be attached to this object object prior to use.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the <paramref name="repository"/> parameter is blank.
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
        /// Pulls the latest commits from the origin remote to the local
        /// repository's master branch.
        /// </summary>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the <see
        /// cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository"/>
        /// method has not been called.
        /// </exception>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
        /// </exception>
        public void Pull()
            => Puller.Pull();

        /// <summary>
        /// Pushes commits from the master branch to a remote called origin.
        /// </summary>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the <see
        /// cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository"/>
        /// method has not been called.
        /// </exception>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
        /// </exception>
        public void Push()
            => Pusher.Push();

        /// <summary>
        /// Synchronizes (i.e., pulls, then pushes) the latest commits from the
        /// origin remote to the local repository's master branch.
        /// </summary>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the <see
        /// cref="M:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository"/>
        /// method has not been called.
        /// </exception>
        /// <exception cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// Thrown if the repository currently in use does not have a valid
        /// configuration associated with it.
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
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationCompleted"/> event.
        /// </summary>
        private void OnSynchronizationCompleted()
            => SynchronizationCompleted?.Invoke(this, EventArgs.Empty);

        /// <summary>
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationFailed"/> event.
        /// </summary>
        /// <param name="e">
        /// A <see
        /// cref="T:xyLOGIX.Interop.GitRepos.Events.SynchronizationFailedEventArgs"/>
        /// that contains the event data.
        /// </param>
        private void OnSynchronizationFailed(SynchronizationFailedEventArgs e)
            => SynchronizationFailed?.Invoke(this, e);

        /// <summary>
        /// Raises the <see
        /// cref="E:xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationStarted"/> event.
        /// </summary>
        private void OnSynchronizationStarted()
            => SynchronizationStarted?.Invoke(this, EventArgs.Empty);
    }
}