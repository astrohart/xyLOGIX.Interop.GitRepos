using System;

namespace xyLOGIX.Interop.GitRepos.Repositories.Actions.Stagers.Events
{
    /// <summary>
    /// Contains the data for a StageFailed event.
    /// </summary>
    public class StageFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.GitRepos.Repositories.Actions.Stagers.Events.StageFailedEventArgs" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="exception">
        /// A <see cref="T:System.Exception" /> containing the
        /// error data.
        /// </param>
        public StageFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        /// <summary>
        /// Gets a <see cref="T:System.Exception" /> containing the error data.
        /// </summary>
        public Exception Exception { get; }
    }
}