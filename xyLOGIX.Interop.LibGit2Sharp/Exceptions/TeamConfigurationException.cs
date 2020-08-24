using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Exceptions
{
    /// <summary>
    /// Exception object to be thrown in the event that a Team object is not properly
    /// configured.
    /// </summary>
    public class TeamConfigurationException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.TeamConfigurationException" />
        /// and returns a reference to it.
        /// </summary>
        public TeamConfigurationException(string message) : base(
            $"The Team is not configured properly.\n\n{message}") { }
    }
}