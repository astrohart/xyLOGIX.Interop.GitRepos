using xyLOGIX.Interop.LibGit2Sharp.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.RepositoryConfigurations
{
    /// <summary>
    /// RepositoryConfiguration for a committer and remote.
    /// </summary>
    public class RepositoryConfiguration : IConfiguration
    {
        /// <summary>
        /// Gets or sets a string containing the email address or handle of the committer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the active configuration --
        /// like Highlander, there can be only one!
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a string containing the name of the committer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a string containing the password utilized to sign in to the
        /// remote.
        /// </summary>
        public string RemotePassword { get; set; }

        /// <summary>
        /// Gets or sets a string containing the username utilized to sign in to the
        /// remote.
        /// </summary>
        public string RemoteUserName { get; set; }

        /// <summary>
        /// Determines whether the specified <paramref name="configuration" /> object has
        /// valid values for its properties.  By valid we mean to say, can be utilized with
        /// either a local or a local-and-remote repository(ies).
        /// </summary>
        /// <param name="configuration">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.RepositoryConfigurations.RepositoryConfiguration" />, the
        /// values of whose properties are to be checked.
        /// </param>
        /// <param name="hasRemote">
        /// True if the remote user name and remote password should
        /// be checked; false otherwise.
        /// </param>
        /// <returns>True if the values of the properties are valid; false otherwise.</returns>
        public static bool IsValid(IConfiguration configuration,
            bool hasRemote = true)
            => configuration != null && (!hasRemote ||
                                         !string.IsNullOrWhiteSpace(
                                             configuration.RemoteUserName)
                                         && !string.IsNullOrWhiteSpace(
                                             configuration
                                                 .RemotePassword));
    }
}