using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xyLOGIX.Interop.Git.Exceptions
{
    public class RepositoryNotConfiguredException : InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of <see cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotConfiguredException" /> and returns a reference to it.
        /// </summary>
        public RepositoryNotConfiguredException() : base("You must supply values for the GitHubName and GitHubEmail properties before calling this method.")
        {
            
        }
    }
}
