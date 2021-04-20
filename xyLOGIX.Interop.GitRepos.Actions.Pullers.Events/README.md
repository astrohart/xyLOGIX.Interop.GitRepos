<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pullers.Events

## Contents

- [PullFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs')
  - [#ctor(exception)](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs-#ctor-System-Exception- 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs-Exception 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs.Exception')
- [PullFailedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventHandler')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs'></a>
## PullFailedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Events

##### Summary

Contains the data for a PullFailed event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[PullFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventArgs') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Reference to a
[Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception')
that contains the error data. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error
data.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventHandler'></a>
## PullFailedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Events

##### Summary

Delegate for a PullFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-PullFailedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.PullFailedEventHandler') | Reference to the instance of the object that raised the
event. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
