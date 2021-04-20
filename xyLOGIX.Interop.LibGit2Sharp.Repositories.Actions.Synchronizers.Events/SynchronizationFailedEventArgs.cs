using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Synchronizers.Events
{
    /// <summary>
    /// Contains the data for a SynchronizationFailed event.
    /// </summary>
    public class SynchronizationFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Synchronizers.Events.SynchronizationFailedEventArgs" /> and returns a reference to it.
        /// </summary>
        /// <param name="exception"/>Reference to a <see cref="T:System.Exception"/> that contains the error data.</param>
        public SynchronizationFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets a reference to a <see cref="T:System.Exception"/> that contains the error data.
        /// </summary>
        public Exception Exception { get; }
    }
}