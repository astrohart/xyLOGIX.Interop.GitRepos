using System;

namespace xyLOGIX.Interop.Git.Repositories.Actions.Committers.Events
{
    /// <summary>
    /// Contains the data for a CommitFailed event.
    /// </summary>
    public class CommitFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Committers.Events.CommitFailedEventArgs" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="exception">
        /// An <see cref="System.Exception" /> that contains the
        /// error data.
        /// </param>
        public CommitFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets an <see cref="T:System.Exception" /> that contains the error data.
        /// </summary>
        public Exception Exception { get; }
    }
}