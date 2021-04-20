using System;
using xyLOGIX.Interop.GitRepos.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions.Exceptions
{
    /// <summary>
    /// Exception object to be thrown in the event that a Team object is not
    /// properly configured.
    /// </summary>
    public class TeamConfigurationException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException" />
        /// and returns a reference to it.
        /// </summary>
        /// <param name="team">
        /// (Required.) Reference to an instance of an object that implements
        /// the <see cref="T:xyLOGIX.Interop.GitRepos.Interfaces.ITeam" />
        /// interface. This object represents the Team that this exception is
        /// talking about.
        /// </param>
        /// <param name="message">
        /// (Optional.) Message, if any, to be added to this exception's default message.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the <paramref name="team" /> parameter is passed a null reference.
        /// </exception>
        public TeamConfigurationException(ITeam team, string message = "") :
            base(
                !string.IsNullOrWhiteSpace(message)
                    ? $"The Team is not configured properly.\n\n{message}"
                    : "The Team is not configured properly."
            )
            => Team = team ?? throw new ArgumentNullException(nameof(team));

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.GitRepos.Interfaces.ITeam" />
        /// interface that represents the Team this exception is talking about.
        /// </summary>
        public ITeam Team { get; }
    }
}