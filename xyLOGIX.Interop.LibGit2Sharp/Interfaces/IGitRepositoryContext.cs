using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines methods and properties for an object that is bound to a Git repository.
    /// </summary>
    /// <remarks>
    /// A repository-bound object is defined as an object that is responsible
    /// for performing actions, such as Commit, Push, Pull, Synchronize, Stage
    /// etc., on a repository's items.
    /// </remarks>
    public interface IGitRepositoryAction
    {
        /// <summary>
        /// Raised when a new GitRepository is attached to this object.
        /// </summary>
        event GitRepositoryAttachedEventHandler GitRepositoryAttached;

        /// <summary>
        /// Raised when a repository is detached from this object.
        /// </summary>
        event EventHandler GitRepositoryDetached;

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IGitRepository" /> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IGitRepository" /> interface that is to be attached
        /// to this object.
        /// </param>
        /// <remarks>
        /// A repository object must be attached to this object object prior to
        /// use.
        /// </remarks>
        /// <exception cref="T:System.ArgumentNullException">
        /// Thrown if the
        /// <paramref name="repository" /> parameter is blank.
        /// </exception>
        void AttachGitRepository(IRepository repository);

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        void DetachGitRepository();
    }
}