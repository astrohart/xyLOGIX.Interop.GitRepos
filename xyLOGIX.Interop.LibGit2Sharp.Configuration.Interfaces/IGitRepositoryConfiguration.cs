namespace xyLOGIX.Interop.LibGit2Sharp.Configuration.Interfaces
{
    /// <summary>
    /// Defines methods and properties for a GitRepositoryConfiguration POCO.
    /// </summary>
    public interface IGitRepositoryConfiguration
    {
        /// <summary>
        /// Gets or sets a string containing the email address or handle of the committer.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets a value that specifies whether this repository has a remote.
        /// </summary>
        bool HasRemote { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the active
        /// repositoryConfiguration --
        /// like Highlander, there can be only one!
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a non-blank commit message is
        /// mandatory.
        /// </summary>
        bool IsCommitMessageMandatory { get; set; }

        /// <summary>
        /// Gets or sets a string containing the name of the committer.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets name of the remote.  Usually set to 'origin' by default.
        /// </summary>
        string RemoteName { get; set; }

        /// <summary>
        /// Gets or sets a string containing the password utilized to sign in to the
        /// remote.
        /// </summary>
        string RemotePassword { get; set; }

        /// <summary>
        /// Gets or sets a string containing the username utilized to sign in to the
        /// remote.
        /// </summary>
        string RemoteUserName { get; set; }
    }
}