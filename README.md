# xyLOGIX.Interop.LibGit2Sharp
This library serves as a user-friendly wrapper for some common Git operations supported by the [libgit2
/
libgit2sharp](https://github.com/libgit2/libgit2sharp) project, such as `git add` (known as Staging), `git commit`, `git pull` and `git push`.  I wanted a way to encapsulate the Wiki-provided examples for these common operations so I could just call them over and over again from code.
## License
This library is released under the MIT License.
# 1. How to Use
This section covers a basic example of how to utilize this library.  It's broken up into several pieces, but the main 'workhorse' class in the library is the `Team` class, that implements the `ITeam` interface.

The `Team` class is called as such because it's designed to mimic the user interface nomenclature of the Team Explorer in editions of Visual Studio that have the GitHub extension installed.

**NOTE** Just because we mentioned GitHub just now, don't think that this library works only with GitHub.  Far from it.  It works with any remote that is accessible via git -- well, at least it's designed to :-)
