<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events

## Contents

- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.Properties.Resources.ResourceManager')
- [SynchronizationFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs')
  - [#ctor(exception)](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs-#ctor-System-Exception- 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs-Exception 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs.Exception')
- [SynchronizationFailedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventHandler')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs'></a>
## SynchronizationFailedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events

##### Summary

Contains the data for a SynchronizationFailed event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of [SynchronizationFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventArgs') and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | Reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error data. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets a reference to a [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error data.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventHandler'></a>
## SynchronizationFailedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events

##### Summary

Delegate for a SynchronizationFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Events-SynchronizationFailedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Events.SynchronizationFailedEventHandler') | Reference to the instance of the object that raised the event. |
