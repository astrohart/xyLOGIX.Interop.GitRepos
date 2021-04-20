using System;
using System.Collections.Generic;
using xyLOGIX.Interop.LibGit2Sharp.Configuration.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Synchronizers.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Teams.Interfaces
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
        /// Gets a reference to a read-only collection of references to instances of
        /// objects that implement the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface.
        /// </summary>
        IReadOnlyCollection<IGitRepositoryConfiguration> GitRepositoryConfigurations
        {
            get;
        }

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
        /// Adds an instance of an object that implements the
        /// <see cref="T:xyLGOIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface to the list that this object maintains and optionally sets it active.
        /// </summary>
        /// <param name="configuration">
        /// Reference to an instance of an object that
        /// implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is to be added to the list of configurations.
        /// </param>
        /// <param name="setActive">
        /// True to set the new configuration as active; false
        /// otherwise.
        /// </param>
        /// <remarks>
        /// Merely setting the <paramref name="configuration" /> object's IsActive property
        /// to be true is not enough to actually associate the configuration with the
        /// repository this Team is using.  To associate it, either pass true for the
        /// <paramref name="setActive" /> parameter (which is the default), or call the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.SetGitRepositoryConfigurationActive" />
        /// next.  If this method's <paramref name="setActive" /> parameter is set to true,
        /// then this method will
        /// set the added configuration active for the caller.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the
        /// <paramref name="configuration" /> parameter has as null reference.
        /// </exception>
        void AddGitRepositoryConfiguration(
            IGitRepositoryConfiguration configuration, bool setActive = true);

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
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAll" /> method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
        /// </exception>
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
        /// commit message.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.
        /// </remarks>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
        /// </exception>
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
        /// commit message.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
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
        /// commit message.
        /// </param>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
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
        /// commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAllAndPush" />
        /// method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
        /// </exception>
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
        /// commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of
        /// files to be staged as part of this commit.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the short commit
        /// message from a detailed commit message.  This method simply calls the
        /// <see cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.CommitAllAndSync" />
        /// method if no
        /// <paramref name="files" /> are specified.
        /// </remarks>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.GitRepositoryNotConfiguredException">
        /// An
        /// active and valid
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository
        /// in use is configured to make commit messages mandatory, yet the
        /// <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown
        /// if a validation error is encountered due to improper configuration of this
        /// Team.
        /// </exception>
        void CommitAndSync(string commitMessage,
            bool addTimestamp = false,
            params string[] files);

        /// <summary>
        /// Deactivates all this team's Git configurations.
        /// </summary>
        /// <remarks>
        /// After this method is called, the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Teams.Team.SetGitRepositoryConfigurationActive" />
        /// method must be called prior to any Git methods being called again.
        /// </remarks>
        void DeactivateAllConfigurations();

        /// <summary>
        /// Sets the specified <paramref name="configuration" /> as active, and associates
        /// it with the GitRepository object that this Team is using.
        /// </summary>
        /// <param name="configuration">
        /// Reference to the instance of the object that
        /// implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is to be made active.  This is also attached to the repository
        /// currently in use.
        /// </param>
        void SetGitRepositoryConfigurationActive(
            IGitRepositoryConfiguration configuration);
    }
}