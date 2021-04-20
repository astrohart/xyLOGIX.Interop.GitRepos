using System;

namespace xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions
{
    public class GitRepositoryNotConfiguredException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException" /> and returns a reference to it.
        /// </summary>
        public GitRepositoryNotConfiguredException() : base("You must supply values for the GitHubName and GitHubEmail properties before calling this method.")
        {
        }
    }
}