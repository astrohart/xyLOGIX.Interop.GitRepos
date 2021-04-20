<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces

## Contents

- [IStager](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.IStager')
  - [StageAll()](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager-StageAll 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.IStager.StageAll')
  - [StageFile(file)](#M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager-StageFile-System-String- 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.IStager.StageFile(System.String)')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager'></a>
## IStager `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces

##### Summary

Defines the methods and properties for a Stager.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager-StageAll'></a>
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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-IStager-StageFile-System-String-'></a>
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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | The item to be staged, whose path is specified by the
`file`
parameter, could not be located. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Stagers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Stagers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
