using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Exceptions
{
    public class GitRepositoryNotConfiguredException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotConfiguredException" /> and returns a reference to it.
        /// </summary>
        public GitRepositoryNotConfiguredException() : base("You must supply values for the GitHubName and GitHubEmail properties before calling this method.")
        {
        }
    }
}