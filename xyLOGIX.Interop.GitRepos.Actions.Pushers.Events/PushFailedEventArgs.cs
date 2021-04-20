using System;

namespace xyLOGIX.Interop.GitRepos.Actions.Pushers.Events
{
    /// <summary>
    /// Contains the data for a PushFailed event.
    /// </summary>
    public class PushFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// Reference to a <see cref="T:System.Exception" /> that
        /// contains the error data.
        /// </param>
        public PushFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets a reference to a <see cref="T:System.Exception" /> that contains the error
        /// data.
        /// </summary>
        public Exception Exception { get; }
    }
}