<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pushers

## Contents

- [Pusher](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.#ctor')
  - [Instance](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-Instance 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.Instance')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-#cctor 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.#cctor')
  - [OnPushCompleted()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushCompleted 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.OnPushCompleted')
  - [OnPushFailed(e)](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushFailed-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.OnPushFailed(xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs)')
  - [OnPushStarted()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushStarted 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.OnPushStarted')
  - [Push()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-Push 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher.Push')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher'></a>
## Pusher `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers

##### Summary

Pushes commits to a remote.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[Pusher](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Pusher').

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushCompleted'></a>
### OnPushCompleted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pushers-Pusher-PushCompleted  'xyLOGIX.Interop.GitRepos.Pushers.Pusher.PushCompleted ')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushFailed-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs-'></a>
### OnPushFailed(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pushers-Pusher-PushFailed  'xyLOGIX.Interop.GitRepos.Pushers.Pusher.PushFailed ')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs') | A
[PushFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-PushFailedEventArgs 'xyLOGIX.Interop.GitRepos.Events.PushFailedEventArgs')
that
contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-OnPushStarted'></a>
### OnPushStarted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Pushers-Pusher-PushStarted  'xyLOGIX.Interop.GitRepos.Pushers.Pusher.PushStarted ')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Pusher-Push'></a>
### Push() `method`

##### Summary

Pushes commits from the master branch to a remote called origin.

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

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
