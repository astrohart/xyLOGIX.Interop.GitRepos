namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Puller.
    /// </summary>
    public interface IPuller : IRepositoryBoundObject
    {
        /// <summary>
        /// Pulls the latest commits from the origin remote to the local repository's
        /// master branch.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubUserName" />
        /// , or
        /// <see
        ///     cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubPassword" />
        /// are blank.
        /// properties are blank.
        /// </exception>
        void Pull();
    }
}