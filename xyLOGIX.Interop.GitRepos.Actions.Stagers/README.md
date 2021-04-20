<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Stagers

## Contents

- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Properties.Resources.ResourceManager')
- [Stager](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.#ctor')
  - [Instance](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-Instance 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.Instance')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-#cctor 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.#cctor')
  - [OnStageCompleted()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageCompleted 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.OnStageCompleted')
  - [OnStageFailed(e)](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageFailed-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.OnStageFailed(xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs)')
  - [OnStageStarted()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageStarted 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.OnStageStarted')
  - [StageAll()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-StageAll 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.StageAll')
  - [StageFile(file)](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-StageFile-System-String- 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager.StageFile(System.String)')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager'></a>
## Stager `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers

##### Summary

Stages changes in the working tree to a local Git repository.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of [Stager](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Stager').

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageCompleted'></a>
### OnStageCompleted() `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Stagers-Stager-StageCompleted  'xyLOGIX.Interop.GitRepos.Stagers.Stager.StageCompleted ') event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageFailed-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs-'></a>
### OnStageFailed(e) `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Stagers-Stager-StageFailed  'xyLOGIX.Interop.GitRepos.Stagers.Stager.StageFailed ') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Events-StageFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Events.StageFailedEventArgs') | A [StageFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-StageFailedEventArgs 'xyLOGIX.Interop.GitRepos.Events.StageFailedEventArgs') that
contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-OnStageStarted'></a>
### OnStageStarted() `method`

##### Summary

Raises the [](#E-xyLOGIX-Interop-GitRepos-Stagers-Stager-StageStarted  'xyLOGIX.Interop.GitRepos.Stagers.Stager.StageStarted ') event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-StageAll'></a>
### StageAll() `method`

##### Summary

Stages all pending changes in the repository.

##### Returns

True if the stage operation succeeded; false otherwise.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the [AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Stager-StageFile-System-String-'></a>
### StageFile(file) `method`

##### Summary

Stages the specified `file` to the repository.

##### Returns

True if the stage operation succeeded; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String containing the full or relative path (to the working
directory) of the item to be staged. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the [AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | The item to be staged, whose path is specified by the `file` parameter, could not be located. |
