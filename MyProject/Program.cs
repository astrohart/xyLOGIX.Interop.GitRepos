using LibGit2Sharp;
using xyLOGIX.Interop.LibGit2Sharp.Configurations;
using xyLOGIX.Interop.LibGit2Sharp.Teams;

namespace MyProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (var team =
                new Team(new Repository(@"/path/to/your/repo/.git")))
            {
                var repositoryConfiguration = new RepositoryConfiguration
                {
                    Name = "Foo bar",
                    Email = "@noneofyourbeeswax",
                    RemoteUserName = "astrohart",
                    RemotePassword = "xxxxx"
                };
                team.AddRepositoryConfiguration(repositoryConfiguration);
                team.SetRepositoryConfigurationActive(repositoryConfiguration);

                team.CommitAllAndSync("Initial add");
            }
        }
    }
}