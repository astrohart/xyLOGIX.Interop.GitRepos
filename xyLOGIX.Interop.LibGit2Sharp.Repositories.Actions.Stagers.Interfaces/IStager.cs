using System;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Interfaces;
using xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Interfaces
{
    /// <summary>
    /// Defines the methods and properties for a Stager.
    /// </summary>
    public interface IStager : IGitRepositoryAction
    {
        /// <summary>
        /// Raised when a Stage operation has completed successfully.
        /// </summary>
        event EventHandler StageCompleted;

        /// <summary>
        /// Raised when a Stage operation has failed.
        /// </summary>
        event StageFailedEventHandler StageFailed;

        /// <summary>
        /// Raised when a Stage operation has been started.
        /// </summary>
        event EventHandler StageStarted;

        /// <summary>
        /// Stages all pending changes in the repository.
        /// </summary>
        /// <returns>
        /// True if the stage operation succeeded; false otherwise.
        /// </returns>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        bool StageAll();

        /// <summary>
        /// Stages the specified <paramref name="file" /> to the repository.
        /// </summary>
        /// <param name="file">
        /// String containing the full or relative path (to the working
        /// directory) of the item to be staged.
        /// </param>
        /// <returns>
        /// True if the stage operation succeeded; false otherwise.
        /// </returns>
        /// <exception
        ///     cref="T:xyLOGIX.Interop.LibGit2Sharp.Exceptions.GitRepositoryNotAttachedException">
        /// Thrown if the
        /// <see
        ///     cref="M:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IGitRepositoryAction.AttachGitRepository" />
        /// method has not been called.
        /// </exception>
        /// <exception cref="T:System.IO.FileNotFoundException">
        /// The item to be staged, whose path is specified by the
        /// <paramref
        ///     name="file" />
        /// parameter, could not be located.
        /// </exception>
        bool StageFile(string file);
    }
}