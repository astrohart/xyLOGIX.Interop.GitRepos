using xyLOGIX.Interop.Git.Repositories.Actions.Stagers.Interfaces;

namespace xyLOGIX.Interop.Git.Repositories.Actions.Stagers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the
    /// <see
    ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Stagers.Interfaces.IStager" />
    /// interface.
    /// </summary>
    public static class GetStager
    {
        /// <summary>
        /// Creates a new instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Stagers.Interfaces.IStager" />
        /// interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Stagers.Interfaces.IStager" />
        /// interface.
        /// </returns>
        public static IStager SoleInstance()
            => Stager.Instance;
    }
}