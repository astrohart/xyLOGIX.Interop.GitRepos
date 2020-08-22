namespace xyLOGIX.Interop.Git.Exceptions
{
    /// <summary>
    /// An exception object that informs the caller that an object that implements the
    /// <see cref="T:LibGit2Sharp.IRepository" /> interface is not attached to the
    /// object is should be.
    /// </summary>
    public class RepositoryNotAttachedException : System.InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.Git.Exceptions.RepositoryNotAttachedException" />
        /// and returns a reference to it.
        /// </summary>
        public RepositoryNotAttachedException() : base(
            "Call AttachRepository before calling this method.")
        { }
    }
}