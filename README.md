# xyLOGIX.Interop.LibGit2Sharp
This library serves as a user-friendly wrapper for some common Git operations supported by the [libgit2
/
libgit2sharp](https://github.com/libgit2/libgit2sharp) project, such as `git add` (known as Staging), `git commit`, `git pull` and `git push`.  

I wanted a way to encapsulate the Wiki-provided examples for these common operations so I could just call them over and over again from code.
## License
This library is released under the MIT License.
# 1. How to Use
This section covers a basic example of how to utilize this library.  It's broken up into several pieces, but the main 'workhorse' class in the library is the `Team` class, that implements the `ITeam` interface.

The `Team` class is called as such because it's designed to mimic the user interface nomenclature of the Team Explorer in editions of Visual Studio that have the GitHub extension installed.

**NOTE** Just because we mentioned GitHub just now, don't think that this library works only with GitHub.  Far from it.  It works with any remote that is accessible via git -- well, at least it's designed to :-)

**NOTE** The library assumes that whatever local repository you're working on has already been configured in advance with ignores, remotes etc.

**NOTE** In order to utilize this library, not only should you reference it, but you must install the ```LibGit2Sharp``` NuGet package to the project that consumes this library.

Here's an example that commits and synchronizes (i.e., pulls, then pushes) all the modified, but not ignored, items in a working directory.  The path to the working directory's `.git` folder is in the variable `WorkingDirectoryRepo`:

```
using LibGit2Sharp;
using xyLOGIX.Interop.Git.GitRepositoryConfigurations;
using xyLOGIX.Interop.Git;

namespace MyProject
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (var team =
                new Team(new GitRepository("/path/to/your/repo/.git")))
            {
                team.AddGitRepositoryConfiguration(
                    new GitRepositoryConfiguration
                    {
                        Name = "xyLOGIX.Interop.Git.Repositories.Actions.Committers.Interfaces bar",
                        Email = "@noneofyourbeeswax",
                        RemoteUserName = "astrohart",
                        RemotePassword = "xxxxx"
                    }
                );

                team.CommitAllAndSync("Initial add");
            }
        }
    }
}
```

Using this wrapper library is literally that easy. 

**NOTE** When creating a new `GitRepositoryConfiguration` object, do not set the `IsActive` property by hand.  Call `Team.SetGitRepositoryConfigurationActive` on it instead.  It should be noted that the `AddGitRepositoryConfiguration` method sets the configuration passed to it as active by default.  Only one configuration can be marked as active at a time.  If a `Team` method is called when more than one configuration is set active, a `TeamConfigurationException` will be thrown.

# 2. Further Work

This library is very bare-bones. Issues and pull requests are welcome to flesh it out, although maintaining this library is not a priority for me.
