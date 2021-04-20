<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Synchronizers

## Contents

- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Properties.Resources.ResourceManager')
- [Synchronizer](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.#ctor')
  - [Instance](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Instance 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Instance')
  - [Puller](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Puller 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Puller')
  - [Pusher](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Pusher 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Pusher')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-#cctor 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.#cctor')
  - [AttachGitRepository(repository)](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-AttachGitRepository-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.AttachGitRepository(LibGit2Sharp.IRepository)')
  - [DetachGitRepository()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-DetachGitRepository 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.DetachGitRepository')
  - [OnSynchronizationCompleted()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationCompleted 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.OnSynchronizationCompleted')
  - [OnSynchronizationFailed(e)](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationFailed-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.OnSynchronizationFailed(xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs)')
  - [OnSynchronizationStarted()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationStarted 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.OnSynchronizationStarted')
  - [Pull()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Pull 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Pull')
  - [Push()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Push 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Push')
  - [Sync()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Sync 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer.Sync')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer'></a>
## Synchronizer `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers

##### Summary

Synchronizes a Git local repository with a remote.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [Synchronizer](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Synchronizer').

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Puller'></a>
### Puller `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IPuller](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-IPuller 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller') interface.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Pusher'></a>
### Pusher `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IPusher](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-IPusher 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.IPusher') interface.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-AttachGitRepository-LibGit2Sharp-IRepository-'></a>
### AttachGitRepository(repository) `method`

##### Summary

Attaches an instance of an object that implements the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface to this object.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to an instance of an object that implements the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface that is to be
attached to this object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the `repository` parameter is blank. |

##### Remarks

A repository object must be attached to this object object prior to use.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-DetachGitRepository'></a>
### DetachGitRepository() `method`

##### Summary

Disassociates this object with the repository.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationCompleted'></a>
### OnSynchronizationCompleted() `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Synchronizers-Synchronizer-SynchronizationCompleted 'xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationCompleted') event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationFailed-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs-'></a>
### OnSynchronizationFailed(e) `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Synchronizers-Synchronizer-SynchronizationFailed 'xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationFailed') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs') | A [SynchronizationFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-SynchronizationFailedEventArgs 'xyLOGIX.Interop.GitRepos.Events.SynchronizationFailedEventArgs')
that contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-OnSynchronizationStarted'></a>
### OnSynchronizationStarted() `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Synchronizers-Synchronizer-SynchronizationStarted 'xyLOGIX.Interop.GitRepos.Synchronizers.Synchronizer.SynchronizationStarted') event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Pull'></a>
### Pull() `method`

##### Summary

Pulls the latest commits from the origin remote to the local
repository's master branch.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the [AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository currently in use does not have a valid
configuration associated with it. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Push'></a>
### Push() `method`

##### Summary

Pushes commits from the master branch to a remote called origin.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the [AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository currently in use does not have a valid
configuration associated with it. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Synchronizer-Sync'></a>
### Sync() `method`

##### Summary

Synchronizes (i.e., pulls, then pushes) the latest commits from the
origin remote to the local repository's master branch.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the [AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository currently in use does not have a valid
configuration associated with it. |
