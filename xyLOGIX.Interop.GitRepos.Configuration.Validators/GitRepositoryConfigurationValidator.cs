using xyLOGIX.Interop.GitRepos.Configuration.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Configuration.Validators
{
    /// <summary>
    /// Methods to validate the values of the properties of objects that are instances
    /// of those which implement the
    /// <see
    ///     cref="T:xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryGitRepositoryConfiguration" />
    /// interface.
    /// </summary>
    public static class GitRepositoryConfigurationValidator
    {
        /// <summary>
        /// Determines whether the specified <paramref name="configuration" />
        /// object has
        /// valid values for its properties.  By valid we mean to say, can be utilized with
        /// either a local or a local-and-remote repository(ies).
        /// </summary>
        /// <param name="configuration">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.GitRepositoryConfigurations.GitRepositoryConfiguration" />
        /// , the
        /// values of whose properties are to be checked.
        /// </param>
        /// <param name="hasRemote">
        /// True if the remote user name and remote password should
        /// be checked; false otherwise.
        /// </param>
        /// <returns>True if the values of the properties are valid; false otherwise.</returns>
        public static bool IsValid(
            IGitRepositoryConfiguration configuration,
            bool hasRemote = true)
            => configuration != null && (!hasRemote ||
                                         !string.IsNullOrWhiteSpace(
                                             configuration
                                                 .RemoteUserName)
                                         && !string
                                             .IsNullOrWhiteSpace(
                                                 configuration
                                                     .RemotePassword)
                                         && !string.IsNullOrWhiteSpace(
                                             configuration.RemoteName)
                );
    }
}