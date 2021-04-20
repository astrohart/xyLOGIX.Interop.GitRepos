using LibGit2Sharp;
using System;
using System.Collections.Generic;
using xyLOGIX.Interop.Git.Configuration.Interfaces;
using xyLOGIX.Interop.Git.Configuration.Validators;

namespace xyLOGIX.Interop.Git.Configuration.Helpers
{
    /// <summary>
    /// Extension methods to manage repository configurations.
    /// </summary>
    public static class GitRepositoryConfigurationHelpers
    {
        /// <summary>
        /// Dictionary that associates repositories to configurations.
        /// </summary>
        private static readonly
            IDictionary<IRepository, IGitRepositoryConfiguration>
            _repositoryConfigurations;

        /// <summary>
        /// Constructs a new instance of
        /// <see
        ///     cref="T:xyLOGIX.Interop.Git.Configuration.Helpers.GitRepositoryConfigurationHelpers" />
        /// and returns a reference to it.
        /// </summary>
        static GitRepositoryConfigurationHelpers()
        {
            _repositoryConfigurations =
                new Dictionary<IRepository, IGitRepositoryConfiguration>();
        }

        /// <summary>
        /// Associates the Git configuration in the specified
        /// <paramref name="configuration" /> with this <paramref name="repository" />.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IGitRepository" /> interface.
        /// </param>
        /// <param name="configuration">
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Interop.Git.Interfaces.IGitRepositoryConfiguration" />
        /// interface.  In order to be attached, its
        /// <see
        ///     cref="P:xyLOGIX.Interop.Git.Interfaces.IGitRepositoryConfiguration.IsActive" />
        /// property must be set to true, and the static method
        /// </param>
        /// <param name="useRemote">
        /// True if the repository is being used with a remote;
        /// false otherwise.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException">A required parameter is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// An attempt was made to
        /// attach a configuration to this repository that is either invalid or inactive.
        /// </exception>
        public static void AttachConfiguration(this IRepository repository,
            IGitRepositoryConfiguration configuration, bool useRemote = true)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository));
            if (configuration == null)
                throw new ArgumentNullException(nameof(configuration));

            if (!GitRepositoryConfigurationValidator.IsValid(configuration,
                    useRemote)
                || !configuration.IsActive)
                throw new InvalidOperationException(
                    "Attempted to attach a repository configuration that is either invalid or inactive.");

            if (_repositoryConfigurations.ContainsKey(repository))
                _repositoryConfigurations.Remove(repository);
            _repositoryConfigurations.Add(repository, configuration);
        }

        /// <summary>
        /// Disassociates a repository configuration object from a repository.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IGitRepository" /> interface that is to have its
        /// configuration detached.
        /// </param>
        /// <returns>
        /// Reference to the instance of the object that implements the
        /// <see cref="T:xyLOGIX.Interop.Git.Interfaces.IGitRepositoryConfiguration" />
        /// that was detached, or null if there was nothing attached in the first place, or
        /// a problem occurred.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// <paramref name="repository" /> is a null reference.
        /// </exception>
        /// <exception cref="T:System.InvalidOperationException">
        /// Thrown if the
        /// <paramref name="repository" /> does not have an associated configuration
        /// currently.
        /// </exception>
        public static IGitRepositoryConfiguration DetachConfiguration(
            this IRepository repository)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository));

            IGitRepositoryConfiguration result;

            if (!_repositoryConfigurations.ContainsKey(repository))
                throw new InvalidOperationException(
                    "This repository has no attached configuration.");

            try
            {
                result = _repositoryConfigurations[repository];
                _repositoryConfigurations.Remove(repository);
            }
            catch
            {
                result = null;
            }

            return result;
        }

        /// <summary>
        /// Obtains a reference to the instance of the object that implements the
        /// <see cref="T:xyLOGIX.Interop.Git.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is currently associated with this <paramref name="repository" />
        /// , or null if there is none.
        /// </summary>
        /// <param name="repository">
        /// Reference to the instance of the object that
        /// implements the <see cref="T:LibGit2Sharp.IGitRepository" /> interface for which
        /// whose corresponding associated configuration should be obtained.
        /// </param>
        /// <returns>
        /// Reference to the the instance of the object that implements the
        /// <see cref="T:xyLOGIX.Interop.Git.Interfaces.IGitRepositoryConfiguration" />
        /// interface that is currently associated with this <paramref name="repository" />
        /// , or null if there is none.
        /// </returns>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the required
        /// <paramref name="repository" /> parameter is passed a null reference.
        /// </exception>
        public static IGitRepositoryConfiguration GetConfiguration(
            this IRepository repository)
        {
            if (repository == null)
                throw new ArgumentNullException(nameof(repository));

            IGitRepositoryConfiguration result = null;

            try
            {
                if (!_repositoryConfigurations.ContainsKey(repository))
                    return result;

                result = _repositoryConfigurations[repository];
            }
            catch
            {
                result = null;
            }

            return result;
        }
    }
}