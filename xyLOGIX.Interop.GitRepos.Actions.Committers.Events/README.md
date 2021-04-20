<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Committers.Events

## Contents

- [CommitFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs')
  - [#ctor(exception)](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs-#ctor-System-Exception- 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs.#ctor(System.Exception)')
  - [Exception](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs-Exception 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs.Exception')
- [CommitFailedEventHandler](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventHandler 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventHandler')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs'></a>
## CommitFailedEventArgs `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Events

##### Summary

Contains the data for a CommitFailed event.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs-#ctor-System-Exception-'></a>
### #ctor(exception) `constructor`

##### Summary

Constructs a new instance of
[CommitFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | An [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the
error data. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs-Exception'></a>
### Exception `property`

##### Summary

Gets an [Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') that contains the error data.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventHandler'></a>
## CommitFailedEventHandler `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Events

##### Summary

Delegate for a CommitFailed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [T:xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventHandler](#T-T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventHandler 'T:xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventHandler') | Reference to the instance of the object that raised the
event. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Events.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
