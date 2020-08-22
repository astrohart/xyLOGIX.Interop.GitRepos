using LibGit2Sharp;
using System;
using System.Linq;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Teams
{
    /// <summary>
    /// Main workhorse of this library.
    /// </summary>
    /// <remarks>
    /// This object is the C# equivalent of the Changes screen of Visual Studio Team
    /// Explorer.  Work with an instance of this class in a using block -- or, be sure
    /// to call its <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.Dispose" />
    /// method when done utilizing it.  You must pass an instance of an object that
    /// implements the <see cref="T:LibGit2Sharp.IRepository" /> interface to its
    /// constructor.
    /// </remarks>
    public class Team : ITeam
    {
        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface.
        /// </summary>
        private IRepository _repository;

        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Teams.Team" /> and returns a
        /// reference to it.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IRepository" /> interface that allows access to a
        /// Git repository.
        /// </param>
        public Team(IRepository repository)
        {
            _repository = repository ??
                          throw new ArgumentNullException(nameof(repository));

            AttachRepositoryToDependencies();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ICommitter" /> interface.
        /// </summary>
        public ICommitter Committer { get; } = Committers.Committer.Instance;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IStager" /> interface.
        /// </summary>
        public IStager Stager { get; } = Stagers.Stager.Instance;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ISynchronizer" />
        /// interface.
        /// </summary>
        public ISynchronizer Synchronizer { get; } =
            Synchronizers.Synchronizer.Instance;

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
        /// commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
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
        public void Commit(string commitMessage, bool addTimestamp = false,
            params string[] files)
        {
            if (!files.Any())
            {
                // Caller really meant to commit all modified files in the working dir.
                CommitAll(commitMessage, addTimestamp);
                return;
            }

            if (files.All(Stager.StageFile))
                Committer.Commit(commitMessage, addTimestamp);
        }

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
        /// commit message.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the required <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.
        /// </remarks>
        public void CommitAll(string commitMessage, bool addTimestamp = false)
        {
            if (Stager.StageAll())
                Committer.Commit(commitMessage, addTimestamp);
        }

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
        /// commit message.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        public void CommitAllAndPush(string commitMessage,
            bool addTimestamp = false)
        {
            CommitAll(commitMessage, addTimestamp);
            Synchronizer.Pusher.Push();
        }

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
        /// commit message.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
        /// properties are blank.
        /// </exception>
        public void CommitAllAndSync(string commitMessage,
            bool addTimestamp = false)
        {
            CommitAll(commitMessage, addTimestamp);
            Synchronizer.Sync();
        }

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
        /// commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
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
        public void CommitAndPush(string commitMessage,
            bool addTimestamp = false,
            params string[] files)
        {
            if (!files.Any())
            {
                CommitAllAndPush(commitMessage, addTimestamp);
                return;
            }

            Commit(commitMessage, addTimestamp, files);
            Synchronizer.Pusher.Push();
        }

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
        /// commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryBoundObject.AttachRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.RepositoryNotConfiguredException">
        /// Thrown
        /// if either the
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubName" />
        /// or
        /// <see cref="P:xyLOGIX.Interop.LibGit2Sharp.Internal.RepositoryBoundObject.GitHubEmail" />
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
        public void CommitAndSync(string commitMessage,
            bool addTimestamp = false,
            params string[] files)
        {
            if (!files.Any())
            {
                CommitAllAndSync(commitMessage, addTimestamp);
                return;
            }

            Commit(commitMessage, addTimestamp, files);
            Synchronizer.Sync();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing,
        /// or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            DetachRepositoryFromDependencies();

            _repository?.Dispose();
            _repository = null;
        }

        /// <summary>
        /// Associates the instance of the object in the _repository field with the
        /// Committer, Stager, and Synchronizer.
        /// </summary>
        private void AttachRepositoryToDependencies()
        {
            Committer.AttachRepository(_repository);
            Stager.AttachRepository(_repository);
            Synchronizer.AttachRepository(_repository);
        }

        /// <summary>
        /// Disassociates the instance of the object in the _repository field from the
        /// Committer, Stager, and Synchronizer.
        /// </summary>
        private void DetachRepositoryFromDependencies()
        {
            Synchronizer.DetachRepository();
            Stager.DetachRepository();
            Committer.DetachRepository();
        }
    }
}