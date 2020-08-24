using System.Collections.Generic;
using System.Linq;
using xyLOGIX.Interop.LibGit2Sharp.Interfaces;

namespace xyLOGIX.Interop.LibGit2Sharp.Validators
{
    /// <summary>
    /// Methods to validate team configurations.
    /// </summary>
    /// <remarks>
    /// Examples of such validation include making sure that a Team has only
    /// one (1) active Repository Configuration at a given time.
    /// </remarks>
    public static class TeamConfigurationValidator
    {
        /// <summary>
        /// Determines whether the collection of
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryConfiguration" />
        /// s passed in the <paramref name="configurations" /> parameter contains exactly
        /// one element that is marked as active.
        /// </summary>
        /// <param name="configurations">
        /// Collection of references to objects that implement
        /// the
        /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Interfaces.IRepositoryConfiguration" />
        /// interface.
        /// </param>
        /// <returns>
        /// True if the collection contains exactly one instance of an active
        /// configuration; false otherwise.
        /// </returns>
        public static bool HasOnlyOneActiveRepoConfig(
            IReadOnlyCollection<IRepositoryConfiguration> configurations)
        {
            var result = false;

            try
            {
                result = configurations.Any() &&
                         configurations.SingleOrDefault(elt => elt.IsActive) !=
                         null;
            }
            catch
            {
                result = false;
            }

            return result;
        }
    }
}