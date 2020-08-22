using System;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines methods and properties for a Team object.
    /// </summary>
    /// <remarks>
    /// Team objects are the main workhorse objects of this library.  These objects are
    /// the C# equivalent of the Changes screen of Visual Studio Team
    /// Explorer.
    /// </remarks>
    public interface ITeam : IDisposable
    {
        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ICommitter" /> interface.
        /// </summary>
        ICommitter Committer { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IStager" /> interface.
        /// </summary>
        IStager Stager { get; }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ISynchronizer" />
        /// interface.
        /// </summary>
        ISynchronizer Synchronizer { get; }

        /// <summary>
        /// Stages all the modified (but not ignored) files in <paramref name="files" />,
        /// and then creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAll" /> method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        void Commit(string commitMessage, bool addTimestamp = false,
            params string[] files);

        /// <summary>
        /// Stages all the modified files in the working directory, except ignored files,
        /// and then creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.
        /// </remarks>
        void CommitAll(string commitMessage, bool addTimestamp = false);

        /// <summary>
        /// Stages all items that are marked as modified in the working tree -- except
        /// ignored items -- and then pushes the commit to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        void CommitAllAndPush(string commitMessage,
            bool addTimestamp = false);

        /// <summary>
        /// Stages all items that are marked as modified in the working tree -- except
        /// ignored items -- and then synchronizes (i.e., pulls, then pushes) the commit to
        /// the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        void CommitAllAndSync(string commitMessage,
            bool addTimestamp = false);

        /// <summary>
        /// Stages all the modified (but not ignored) files in the
        /// <paramref name="files" /> collection, creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp, and then pushes the
        /// Commit to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAllAndPush" />
        /// method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        void CommitAndPush(string commitMessage,
            bool addTimestamp = false,
            params string[] files);

        /// <summary>
        /// Stages all the modified (but not ignored) files in the
        /// <paramref name="files" /> collection, and then creates a new Commit with the
        /// specified <aramref name="commitMessage" /> and optional timestamp, and then
        /// synchronizes (i.e., pulls and then pushes) the Commit(s) to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit
        /// commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the
        /// commit commitMessage.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
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
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.Git.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAllAndSync" />
        /// method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        void CommitAndSync(string commitMessage,
            bool addTimestamp = false,
            params string[] files);
    }
}