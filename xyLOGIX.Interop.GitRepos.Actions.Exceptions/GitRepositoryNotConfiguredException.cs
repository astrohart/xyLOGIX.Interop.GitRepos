using System;

namespace xyLOGIX.Interop.GitRepos.Actions.Exceptions
{
    /// <summary>
    /// Exception type used to inform the developer that the Git repository was
    /// not configured properly before a repository action, such as Commit,
    /// Stage, Pull, or Push, was tried on it.
    /// </summary>
    public class GitRepositoryNotConfiguredException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException" />
        /// and returns a reference to it.
        /// </summary>
        public GitRepositoryNotConfiguredException() : base(
            "You must supply values for the GitHubName and GitHubEmail properties before calling this method."
        ) { }
    }
}