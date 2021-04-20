
using xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces;

namespace xyLOGIX.Interop.GitRepos.Actions.Pullers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller" /> interface.
    /// </summary>
    public static class GetPuller
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller" /> interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller" /> interface.
        /// </returns>
        public static IPuller SoleInstance()
            => Puller.Instance;
    }
}