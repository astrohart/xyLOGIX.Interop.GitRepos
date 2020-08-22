using xyLOGIX.Interop.Git.Interfaces;

namespace xyLOGIX.Interop.Git.Changes
{
    /// <summary>
    /// Stages changes in the working tree to a local Git repository.
    /// </summary>
    public class Stager : RepositoryBoundObject
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Stager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Stager()
        {
            Repository =
                null; // initialize this object as unattached by default
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.Git.Changes.Stager" />.
        /// </summary>
        public static Stager Instance { get; } = new Stager();
    }
}