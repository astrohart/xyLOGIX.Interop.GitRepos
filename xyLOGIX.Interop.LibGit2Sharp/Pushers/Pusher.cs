using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Internal;

namespace xyLOGIX.Interop.LibGit2Sharp.Pushers
{
    /// <summary>
    /// Pushes commits to a remote.
    /// </summary>
    public class Pusher : RepositoryBoundObject, IPusher
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
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Pushers.Pusher" />.
        /// </summary>
        public static Pusher Instance { get; } = new Pusher();

        /// <summary>
        /// Pushes commits to a remote.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        public void Push()
            => throw new NotImplementedException();

        /// <summary>
        /// Occurs when a Push operation has been completed.
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