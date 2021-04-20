using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Interop.LibGit2Sharp.Configuration.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Factories;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Committers.Interfaces;
using xyLOGIX.Interop.Git.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Factories;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Interfaces;

namespace xyLOGIX.Interop.Git
{
    /// <summary>
    /// Main workhorse of this library.
    /// </summary>
    /// <remarks>
    /// This object is the C# equivalent of the Changes screen of Visual Studio
    /// Team Explorer. Work with an instance of this class in a using block --
    /// or, be sure to call its
    /// <see
    ///     cref="M:xyLOGIX.Interop.Git.Team.Dispose" />
    /// method when
    /// done utilizing it. You must pass an instance of an object that
    /// implements the <see cref="T:LibGit2Sharp.IRepository" /> interface to its
    /// constructor.
    /// </remarks>
    public class Team : ITeam
    {
        /// <summary>
        /// Collection of references to instances of objects that implement the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface.
        /// </summary>
        private readonly List<IGitRepositoryConfiguration>
            _repositoryConfigurations;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:LibGit2Sharp.IRepository" />
        /// interface.
        /// </summary>
        private IRepository _repository;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Team" />
        /// and returns a
        /// reference to it.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:LibGit2Sharp.IGitRepository" />
        /// interface that allows access
        /// to a Git repository.
        /// </param>
        public Team(IRepository repository)
        {
            _repository = repository ??
                          throw new ArgumentNullException(nameof(repository));

            _repositoryConfigurations = new List<IGitRepositoryConfiguration>();

            AttachGitRepositoryToDependencies();
        }

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ICommitter" /> interface.
        /// </summary>
        public ICommitter Committer { get; } = GetCommitter.SoleInstance();

        /// <summary>
        /// Gets a reference to a read-only collection of references to
        /// instances of objects that implement the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface.
        /// </summary>
        public IReadOnlyCollection<IGitRepositoryConfiguration>
            GitRepositoryConfigurations
            => _repositoryConfigurations;

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IStager" /> interface.
        /// </summary>
        public IStager Stager { get; } = GetStager.SoleInstance();

        /// <summary>
        /// Gets a reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.ISynchronizer" />
        /// interface.
        /// </summary>
        public ISynchronizer Synchronizer { get; } =
            Synchronizers.Synchronizer.Instance;

        /// <summary>
        /// Adds an instance of an object that implements the
        /// <see
        ///     cref="T:xyLGOIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface to the list that this object maintains and optionally sets
        /// it active.
        /// </summary>
        /// <param name="configuration">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is to be added to the list of configurations.
        /// </param>
        /// <param name="setActive">
        /// True to set the new configuration as active; false otherwise.
        /// </param>
        /// <remarks>
        /// Merely setting the <paramref name="configuration" /> object's
        /// IsActive property to be true is not enough to actually associate the
        /// configuration with the repository this Team is using. To associate
        /// it, either pass true for the <paramref name="setActive" /> parameter
        /// (which is the default), or call the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Team.SetGitRepositoryConfigurationActive" />
        /// next. If this method's <paramref name="setActive" /> parameter is set
        /// to true, then this method will set the added configuration active
        /// for the caller.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the <paramref name="configuration" /> parameter has as null
        /// reference.
        /// </exception>
        public void AddGitRepositoryConfiguration(
            IGitRepositoryConfiguration configuration, bool setActive = true)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            _repositoryConfigurations.Add(configuration);
            if (setActive) SetGitRepositoryConfigurationActive(configuration);
        }

        /// <summary>
        /// Stages all the modified (but not ignored) files in
        /// <paramref
        ///     name="files" />
        /// , and then creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of files to
        /// be staged as part of this commit.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the
        /// short commit message from a detailed commit message. This method
        /// simply calls the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Team.CommitAll" />
        /// method
        /// if no <paramref name="files" /> are specified.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void Commit(string commitMessage, bool addTimestamp = false,
            params string[] files)
        {
            Validate();

            if (_repository.GetConfiguration() == null ||
                !GitRepositoryConfigurationValidator.IsValid(
                    _repository.GetConfiguration()
                ))
                throw new GitRepositoryNotConfiguredException();

            if (_repository.GetConfiguration()
                           .IsCommitMessageMandatory &&
                string.IsNullOrWhiteSpace(commitMessage))
                throw new InvalidOperationException(
                    "A commit message is assumed to be mandatory."
                );

            if (!files.Any())
            {
                // Caller really meant to commit all modified files in the
                // working dir.
                CommitAll(commitMessage, addTimestamp);
                return;
            }

            if (files.All(Stager.StageFile))
                Committer.Commit(commitMessage, addTimestamp);
        }

        /// <summary>
        /// Stages all the modified files in the working directory, except
        /// ignored files, and then creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the
        /// short commit message from a detailed commit message.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void CommitAll(string commitMessage, bool addTimestamp = false)
        {
            Validate();

            if (_repository.GetConfiguration() == null ||
                !GitRepositoryConfigurationValidator.IsValid(
                    _repository.GetConfiguration()
                ))
                throw new GitRepositoryNotConfiguredException();

            if (_repository.GetConfiguration()
                           .IsCommitMessageMandatory &&
                string.IsNullOrWhiteSpace(commitMessage))
                throw new InvalidOperationException(
                    "A commit message is assumed to be mandatory."
                );

            if (Stager.StageAll())
                Committer.Commit(commitMessage, addTimestamp);
        }

        /// <summary>
        /// Stages all items that are marked as modified in the working tree --
        /// except ignored items -- and then pushes the commit to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void CommitAllAndPush(string commitMessage,
            bool addTimestamp = false)
        {
            CommitAll(commitMessage, addTimestamp);
            Synchronizer.Pusher.Push();
        }

        /// <summary>
        /// Stages all items that are marked as modified in the working tree --
        /// except ignored items -- and then synchronizes (i.e., pulls, then
        /// pushes) the commit to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void CommitAllAndSync(string commitMessage,
            bool addTimestamp = false)
        {
            CommitAll(commitMessage, addTimestamp);
            Synchronizer.Sync();
        }

        /// <summary>
        /// Stages all the modified (but not ignored) files in the
        /// <paramref
        ///     name="files" />
        /// collection, creates a new Commit with the specified
        /// <paramref name="commitMessage" /> and optional timestamp, and then
        /// pushes the Commit to the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of files to
        /// be staged as part of this commit.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the
        /// short commit message from a detailed commit message. This method
        /// simply calls the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Team.CommitAllAndPush" />
        /// method if no <paramref name="files" /> are specified.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void CommitAndPush(string commitMessage,
            bool addTimestamp = false, params string[] files)
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
        /// <paramref
        ///     name="files" />
        /// collection, and then creates a new Commit with the
        /// specified <aramref name="commitMessage" /> and optional timestamp,
        /// and then synchronizes (i.e., pulls and then pushes) the Commit(s) to
        /// the remote.
        /// </summary>
        /// <param name="commitMessage">
        /// (Required.)String containing the commit commitMessage.
        /// </param>
        /// <param name="addTimestamp">
        /// (Optional.) Set to true to add the timestamp to the commit message.
        /// </param>
        /// <param name="files">
        /// Collection of path names, either absolute or relative, of files to
        /// be staged as part of this commit.
        /// </param>
        /// <remarks>
        /// Use two newline characters, '\n\n', in the message to separate the
        /// short commit message from a detailed commit message. This method
        /// simply calls the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Team.CommitAllAndSync" />
        /// method if no <paramref name="files" /> are specified.
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
        /// An active and valid
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// is not associated with the repository.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown when the repository in use is configured to make commit
        /// messages mandatory, yet the <paramref name="commitMessage" /> is blank.
        /// </exception>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        public void CommitAndSync(string commitMessage,
            bool addTimestamp = false, params string[] files)
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
        /// Deactivates all this team's Git configurations.
        /// </summary>
        /// <remarks>
        /// After this method is called, the
        /// <see
        ///     cref="M:xyLOGIX.Interop.Git.Team.SetGitRepositoryConfigurationActive" />
        /// method must be called prior to any Git methods being called again.
        /// </remarks>
        public void DeactivateAllConfigurations()
        {
            if (_repository == null)
                return;

            if (!_repositoryConfigurations.Any())
                return;

            _repositoryConfigurations.ForEach(DeactivateConfiguration);
            _repository.DetachConfiguration();
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing,
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            DeactivateAllConfigurations();
            DetachGitRepositoryFromDependencies();

            _repository?.Dispose();
            _repository = null;
        }

        /// <summary>
        /// Sets the specified <paramref name="configuration" /> as active, and
        /// associates it with the GitRepository object that this Team is using.
        /// </summary>
        /// <param name="configuration">
        /// Reference to the instance of the object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is to be made active. This is also attached to the
        /// repository currently in use.
        /// </param>
        public void SetGitRepositoryConfigurationActive(
            IGitRepositoryConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            if (_repository == null)
                throw new InvalidOperationException(
                    "A repository is not associated with this Team yet."
                );

            if (_repositoryConfigurations == null ||
                !_repositoryConfigurations.Any())
                throw new InvalidOperationException(
                    "No configurations are registered."
                );

            if (!_repositoryConfigurations.Contains(configuration))
                throw new InvalidOperationException(
                    "The configuration object passed has not been added to the configuration collection."
                );

            _repository.DetachConfiguration();

            DeactivateAllConfigurations();
            configuration.IsActive = true;
            _repository.AttachConfiguration(configuration);
        }

        /// <summary>
        /// Deactivates the specified repository <paramref name="configuration" />.
        /// </summary>
        /// <param name="configuration">
        /// Reference to an instance of an object that implements the
        /// <see
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is to be deactivated.
        /// </param>
        /// <remarks>
        /// This method exists purely for fluent use in LINQ queries.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required parameter, <paramref name="configuration" />,
        /// is passed a <see langword="null" /> value.
        /// </exception>
        private static void DeactivateConfiguration(
            IGitRepositoryConfiguration configuration)
        {
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            configuration.IsActive = false;
        }

        /// <summary>
        /// Associates the instance of the object in the _repository field with
        /// the Committer, Stager, and Synchronizer.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Team.Committer" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Team.Stager" />
        /// , or the
        /// <see cref="P:xyLOGIX.Interop.Git.Team.Synchronizer" />
        /// property are <see langword="null" />.
        /// </exception>
        private void AttachGitRepositoryToDependencies()
        {
            if (Committer == null || Stager == null || Synchronizer == null)
                throw new InvalidOperationException(
                    "Either the Committer, the Stager, or the Synchronizer components are not initialized, or all three."
                );

            Committer.AttachGitRepository(_repository);
            Stager.AttachGitRepository(_repository);
            Synchronizer.AttachGitRepository(_repository);
        }

        /// <summary>
        /// Disassociates the instance of the object in the _repository field
        /// from the Committer, Stager, and Synchronizer.
        /// </summary>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Team.Committer" />
        /// ,
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Team.Stager" />
        /// , or the
        /// <see cref="P:xyLOGIX.Interop.Git.Team.Synchronizer" />
        /// property are <see langword="null" />.
        /// </exception>
        private void DetachGitRepositoryFromDependencies()
        {
            if (Committer == null || Stager == null || Synchronizer == null)
                throw new InvalidOperationException(
                    "Either the Committer, the Stager, or the Synchronizer components are not initialized, or all three."
                );

            Synchronizer.DetachGitRepository();
            Stager.DetachGitRepository();
            Committer.DetachGitRepository();
        }

        /// <summary>
        /// This method runs validation rules against the
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Team.GitRepositoryConfigurations" />
        /// collection.
        /// </summary>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Exceptions.TeamConfigurationException">
        /// Thrown if a validation error is encountered due to improper
        /// configuration of this Team.
        /// </exception>
        private void Validate()
        {
            if (GitRepositoryConfigurations.Any() &&
                !TeamConfigurationValidator.HasOnlyOneActiveRepoConfig(
                    GitRepositoryConfigurations
                ))
                throw new TeamConfigurationException(
                    this,
                    "The Team has more than one configuration marked as active."
                );
        }
    }
}