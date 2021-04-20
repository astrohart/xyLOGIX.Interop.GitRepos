<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces

## Contents

- [IPuller](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-IPuller 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller')
  - [Pull()](#M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-IPuller-Pull 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.IPuller.Pull')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-IPuller'></a>
## IPuller `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces

##### Summary

Defines the methods and properties for a Puller.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-IPuller-Pull'></a>
### Pull() `method`

##### Summary

Pulls the latest commits from the origin remote to the local repository's
master branch.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown
if the repository currently in use does not have a valid configuration
associated with it. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pullers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pullers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
