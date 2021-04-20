<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pushers.Events

## Contents

- [PushFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs')
  - [#ctor(exception)](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs-#ctor-System-Exception- 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs-Exception 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs.Exception')
- [PushFailedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventHandler')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs'></a>
## PushFailedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Events

##### Summary

Contains the data for a PushFailed event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[PushFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that
contains the error data. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error
data.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventHandler'></a>
## PushFailedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Events

##### Summary

Delegate for a PushFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-PushFailedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.PushFailedEventHandler') | Reference to the instance of the object that raised the
event. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
