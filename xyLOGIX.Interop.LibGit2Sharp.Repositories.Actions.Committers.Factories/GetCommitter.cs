using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Factories" />
    /// interface.
    /// </summary>
    public static class GetCommitter
    {
        /// <summary>
        /// Gets the sole instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Interfaces.ICommitter" />
        /// interface.
        /// </summary>
        public static ICommitter SoleInstance()
            => Committer.Instance;
    }
}