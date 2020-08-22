using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Exceptions
{
    public class RepositoryNotConfiguredException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException" /> and returns a reference to it.
        /// </summary>
        public RepositoryNotConfiguredException() : base("You must supply values for the GitHubName and GitHubEmail properties before calling this method.")
        {
        }
    }
}