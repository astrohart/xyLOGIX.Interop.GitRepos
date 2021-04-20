<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions

## Contents

- [GitRepositoryAction](#T-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-#ctor 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.#ctor')
  - [GitRepository](#P-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-GitRepository 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.GitRepository')
  - [AttachGitRepository(repository)](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-AttachGitRepository-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.AttachGitRepository(LibGit2Sharp.IRepository)')
  - [DetachGitRepository()](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-DetachGitRepository 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.DetachGitRepository')
  - [OnGitRepositoryAttached(e)](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-OnGitRepositoryAttached-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.OnGitRepositoryAttached(xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs)')
  - [OnGitRepositoryDetached()](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-OnGitRepositoryDetached 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.OnGitRepositoryDetached')
  - [StripRepoDirFromFilePath(path)](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-StripRepoDirFromFilePath-System-String- 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.StripRepoDirFromFilePath(System.String)')
  - [ValidateConfiguration()](#M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-ValidateConfiguration 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.ValidateConfiguration')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction'></a>
## GitRepositoryAction `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions

##### Summary

Defines methods and properties that are common to all repository-bound objects.

##### Remarks

A repository-bound object is defined as an object that is responsible
for performing actions, such as Commit, Push, Pull, Synchronize, Stage
etc., on a repository's items.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[GitRepositoryAction](#T-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-GitRepository'></a>
### GitRepository `property`

##### Summary

Gets or sets a reference to an object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository')
interface that this object is
currently working with.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-AttachGitRepository-LibGit2Sharp-IRepository-'></a>
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

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-DetachGitRepository'></a>
### DetachGitRepository() `method`

##### Summary

Disassociates this object with the repository.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-OnGitRepositoryAttached-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs-'></a>
### OnGitRepositoryAttached(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Changes-Stager-GitRepositoryAttached 'xyLOGIX.Interop.GitRepos.Changes.Stager.GitRepositoryAttached')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs') | A
[GitRepositoryAttachedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-GitRepositoryAttachedEventArgs 'xyLOGIX.Interop.GitRepos.Events.GitRepositoryAttachedEventArgs')
that contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-OnGitRepositoryDetached'></a>
### OnGitRepositoryDetached() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Changes-Stager-GitRepositoryDetached-GitRepositoryDetached 'xyLOGIX.Interop.GitRepos.Changes.Stager.GitRepositoryDetached.GitRepositoryDetached')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-StripRepoDirFromFilePath-System-String-'></a>
### StripRepoDirFromFilePath(path) `method`

##### Summary

Strips the repository's working directory path from a full pathname,
making it relative to the tree root.

##### Returns

Path of the item, relative to the working tree root, or the empty
string if an error occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the full path and filename of a repository item. |

##### Remarks

If the required parameter, `path`, is a blank
string or refers to the pathname of a file that does not exist, or
if the
[GitRepository](#P-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-GitRepository 'xyLOGIX.Interop.GitRepos.Actions.GitRepositoryAction.GitRepository')
property has a `null` value, then this method does
nothing and returns the blank string as the result.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-GitRepositoryAction-ValidateConfiguration'></a>
### ValidateConfiguration() `method`

##### Summary

Determine whether the configuration is set up.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository does not have a valid object that
implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface associated with it. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
