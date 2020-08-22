using LibGit2Sharp;
using System;
using xyLOGIX.Interop.LibGit2Sharp.Events;

namespace xyLOGIX.Interop.LibGit2Sharp.Interfaces
{
    /// <summary>
    /// Defines methods and properties for an object that is bound to a Git repository.
    /// </summary>
    public interface IRepositoryBoundObject
    {
        /// <summary>
        /// Raised when a new Repository is attached to this object.
        /// </summary>
        event RepositoryAttachedEventHandler RepositoryAttached;

        /// <summary>
        /// Raised when a repository is detached from this object.
        /// </summary>
        event EventHandler RepositoryDetached;

        /// <summary>
        /// Gets or sets the email address and/or social media POC to utilize for operations.
        /// </summary>
        string GitHubEmail { get; set; }

        /// <summary>
        /// Gets or sets the name to be utilized for operations.
        /// </summary>
        string GitHubName { get; set; }

        /// <summary>
        /// Attaches an instance of an object that implements the
        /// <see cref="T:LibGit2Sharp.IRepository" /> interface to this object.
        /// </summary>
        /// <param name="repository">
        /// Reference to an instance of an object that implements
        /// the <see cref="T:LibGit2Sharp.IRepository" /> interface that is to be attached
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
        void AttachRepository(IRepository repository);

        /// <summary>
        /// Disassociates this object with the repository.
        /// </summary>
        void DetachRepository();
    }
}