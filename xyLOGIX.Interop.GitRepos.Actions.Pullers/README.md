<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pullers

## Contents

- [Puller](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.#ctor')
  - [Instance](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-Instance 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.Instance')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-#cctor 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.#cctor')
  - [OnPullCompleted()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullCompleted 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.OnPullCompleted')
  - [OnPullFailed(e)](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullFailed-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.OnPullFailed(xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs)')
  - [OnPullStarted()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullStarted 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.OnPullStarted')
  - [Pull()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-Pull 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller.Pull')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller'></a>
## Puller `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers

##### Summary

Pulls changes from the remote to the local repository.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[Puller](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Puller').

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullCompleted'></a>
### OnPullCompleted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pullers-Puller-PullCompleted  'xyLOGIX.Interop.GitRepos.Pullers.Puller.PullCompleted ')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullFailed-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs-'></a>
### OnPullFailed(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pullers-Puller-PullFailed  'xyLOGIX.Interop.GitRepos.Pullers.Puller.PullFailed ')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs') | A
[PullFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-PullFailedEventArgs 'xyLOGIX.Interop.GitRepos.Events.PullFailedEventArgs')
that
contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-OnPullStarted'></a>
### OnPullStarted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pullers-Puller-PullStarted  'xyLOGIX.Interop.GitRepos.Pullers.Puller.PullStarted ')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Puller-Pull'></a>
### Pull() `method`

##### Summary

Pulls the latest commits from the origin remote to the local
repository's master branch.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository currently in use does not have a valid
configuration associated with it. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
