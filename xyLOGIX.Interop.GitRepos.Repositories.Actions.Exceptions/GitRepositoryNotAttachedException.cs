namespace xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions
{
    /// <summary>
    /// An exception object that informs the caller that an object that implements the
    /// <see cref="T:LibGit2Sharp.IGitRepository" /> interface is not attached to the
    /// object is should be.
    /// </summary>
    public class GitRepositoryNotAttachedException : System.InvalidOperationException
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.GitRepos.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException" />
        /// and returns a reference to it.
        /// </summary>
        public GitRepositoryNotAttachedException() : base(
            "Call AttachGitRepository before calling this method.")
        { }
    }
}