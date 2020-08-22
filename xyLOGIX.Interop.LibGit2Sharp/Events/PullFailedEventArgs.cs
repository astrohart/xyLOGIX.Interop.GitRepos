using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Events
{
    /// <summary>
    /// Contains the data for a PullFailed event.
    /// </summary>
    public class PullFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.PullFailedEventArgs" /> and
        /// returns a reference to it.
        /// </summary>
        /// <param name="exception" />
        /// Reference to a
        /// <see cref="T:System.Exception" />
        /// that contains the error data.
        /// </param>
        public PullFailedEventArgs(Exception exception)
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