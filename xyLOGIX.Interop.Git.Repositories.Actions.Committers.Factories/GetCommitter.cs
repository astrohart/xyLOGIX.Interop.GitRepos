using xyLOGIX.Interop.Git.Repositories.Actions.Committers.Interfaces;

namespace xyLOGIX.Interop.Git.Repositories.Actions.Committers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Committers.Interfaces.ICommitter" />
    /// interface.
    /// </summary>
    public static class GetCommitter
    {
        /// <summary>
        /// Gets a reference to the sole instance of the object that implements
        /// the
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Committers.Interfaces.ICommitter" />
        /// interface.
        /// </summary>
        public static ICommitter SoleInstance()
            => Committer.Instance;
    }
}