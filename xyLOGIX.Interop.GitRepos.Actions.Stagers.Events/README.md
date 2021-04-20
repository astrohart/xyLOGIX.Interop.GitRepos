<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Stagers.Events

## Contents

- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.Properties.Resources.ResourceManager')
- [StageFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs')
  - [#ctor(exception)](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs-#ctor-System-Exception- 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs-Exception 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs.Exception')
- [StageFailedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventHandler')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs'></a>
## StageFailedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Events

##### Summary

Contains the data for a StageFailed event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[StageFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs') and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | A [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') containing the
error data. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') containing the error data.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventHandler'></a>
## StageFailedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Events

##### Summary

Delegate for a StageFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventHandler') | Reference to the instance of the object that raised the
event. |
