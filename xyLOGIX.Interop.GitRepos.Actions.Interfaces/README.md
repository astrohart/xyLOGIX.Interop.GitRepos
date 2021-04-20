<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Interfaces

## Contents

- [IGitRepositoryAction](#T-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.IGitRepositoryAction')
  - [AttachGitRepository(repository)](#M-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction-AttachGitRepository-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.IGitRepositoryAction.AttachGitRepository(LibGit2Sharp.IRepository)')
  - [DetachGitRepository()](#M-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction-DetachGitRepository 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.IGitRepositoryAction.DetachGitRepository')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction'></a>
## IGitRepositoryAction `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Interfaces

##### Summary

Defines methods and properties for an object that is bound to a Git repository.

##### Remarks

A repository-bound object is defined as an object that is responsible
for performing actions, such as Commit, Push, Pull, Synchronize, Stage
etc., on a repository's items.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction-AttachGitRepository-LibGit2Sharp-IRepository-'></a>
### AttachGitRepository(repository) `method`

##### Summary

Attaches an instance of an object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository')
interface to this object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to an instance of an object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository')
interface that is to be
attached to this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the `repository` parameter is blank. |

##### Remarks

A repository object must be attached to this object object prior to use.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Interfaces-IGitRepositoryAction-DetachGitRepository'></a>
### DetachGitRepository() `method`

##### Summary

Disassociates this object with the repository.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
