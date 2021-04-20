<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces

## Contents

- [ISynchronizer](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer')
  - [Pull()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Pull 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer.Pull')
  - [Push()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Push 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer.Push')
  - [Sync()](#M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Sync 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.ISynchronizer.Sync')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer'></a>
## ISynchronizer `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces

##### Summary

Defines methods and properties for a Synchronizer object.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Pull'></a>
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

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Push'></a>
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

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-ISynchronizer-Sync'></a>
### Sync() `method`

##### Summary

Synchronizes (i.e., pulls, then pushes) the latest commits from the
origin remote to the local repository's master branch.

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

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Synchronizers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Synchronizers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
