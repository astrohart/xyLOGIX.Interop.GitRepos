using xyLOGIX.Interop.Git.Repositories.Actions.Pushers.Interfaces;

namespace xyLOGIX.Interop.Git.Repositories.Actions.Pushers.Factories
{
    /// <summary>
    /// Creates instances of objects that implement the <see cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Pushers.Interfaces.IPusher" /> interface.
    /// </summary>
    public static class GetPusher
    {
        /// <summary>
        /// Creates a new instance of an object that implements the <see cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Pushers.Interfaces.IPusher" /> interface and returns a reference to it.
        /// </summary>
        /// <returns>
        /// Reference to an instance of an object that implements the <see cref="T:xyLOGIX.Interop.Git.Repositories.Actions.Pushers.Interfaces.IPusher" /> interface.
        /// </returns>
        public static IPusher SoleInstance()
            => Pusher.Instance;
    }
}