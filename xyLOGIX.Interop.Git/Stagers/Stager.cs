using LibGit2Sharp;
using System;
using System.Text;
using xyLOGIX.Interop.Git.Interfaces;

namespace xyLOGIX.Interop.Git.Changes
{
    /// <summary>
    /// Stages changes in the working tree to a local Git repository.
    /// </summary>
    public class Stager : RepositoryBoundObject
    {
        /// <summary>
        /// Empty, static constructor to prohibit direct allocation of this class.
        /// </summary>
        static Stager() { }

        /// <summary>
        /// Empty, protected constructor to prohibit direct allocation of this class.
        /// </summary>
        protected Stager()
        {
            Repository =
                null; // initialize this object as unattached by default
        }

        /// <summary>
        /// Gets a reference to the one and only instance of
        /// <see cref="T:xyLOGIX.Interop.Git.Changes.Stager" />.
        /// </summary>
        public static Stager Instance { get; } = new Stager();

        /// <summary>
        /// Stages all pending changes in the repository.
        /// </summary>
        /// <returns>True if the stage operation succeeded; false otherwise.</returns>
        public bool StageAll()
        {
            Console.WriteLine($"Staging changes to local repo...");

            if (Repository == null)
                return false;   // repository not attached.

            try
            {
                Commands.Stage(
                        Repository, "*"
                    );

                Console.WriteLine("*** Stage operation successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Failed to add project to Git repository.\r\n{ex.Message}\r\n\t{ex.StackTrace}");

                return false;
            }

            return true;
        }
    }
}