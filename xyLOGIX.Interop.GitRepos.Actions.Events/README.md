<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Events

## Contents

- [GitRepositoryAttachedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs')
  - [#ctor(repository)](#M-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs-#ctor-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs.#ctor(LibGit2Sharp.IRepository)')
  - [GitRepository](#P-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs-GitRepository 'xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs.GitRepository')
- [GitRepositoryAttachedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventHandler')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Events.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs'></a>
## GitRepositoryAttachedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Events

##### Summary

Contains the data for a GitRepositoryAttached event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs-#ctor-LibGit2Sharp-IRepository-'></a>
### #ctor(repository) `constructor`

##### Summary

Constructs a new instance of
[GitRepositoryAttachedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-GitRepositoryAttachedEventArgs 'xyLOGIX.Interop.GitRepos.Events.GitRepositoryAttachedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to the instance of the object that
implements the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface to which the
sending object has just been attached. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventArgs-GitRepository'></a>
### GitRepository `property`

##### Summary

Gets a reference to the instance of the object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface to which the sending object
has just been attached.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventHandler'></a>
## GitRepositoryAttachedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Events

##### Summary

Delegate for a GitRepositoryAttached event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Events-GitRepositoryAttachedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventHandler') | Reference to the instance of the object that raised the
event. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
