using xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer" />
    /// interface.
    /// </summary>
    public static class GetSynchronizer
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer" />
        /// interface.
        /// </returns>
        public static ISynchronizer SoleInstance()
            => Synchronizer.Instance;
    }
}