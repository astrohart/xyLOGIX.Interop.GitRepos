using xyLOGIX.Interop.LibGit2Sharp.Configuration.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Configuration
{
    /// <summary>
    /// GitRepositoryConfiguration for a committer and remote.
    /// </summary>
    public class GitRepositoryConfiguration : IGitRepositoryConfiguration
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Configuration.GitRepositoryConfiguration" />
        /// and returns a reference to it.
        /// </summary>
        /// <remarks>This constructor sets default values for some of the properties.</remarks>
        public GitRepositoryConfiguration()
        {
            HasRemote = true; // by default
            IsActive = false;
            IsCommitMessageMandatory = true;
            RemoteName = "origin";
        }

        /// <summary>
        /// Gets or sets a string containing the email address or handle of the committer.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value that specifies whether this repository has a remote.
        /// </summary>
        public bool HasRemote { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this is the active
        /// repositoryConfiguration --
        /// like Highlander, there can be only one!
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a non-blank commit message is
        /// mandatory.
        /// </summary>
        public bool IsCommitMessageMandatory { get; set; }

        /// <summary>
        /// Gets or sets a string containing the name of the committer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets name of the remote.  Usually set to 'origin' by default.
        /// </summary>
        public string RemoteName { get; set; }

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
    }
}