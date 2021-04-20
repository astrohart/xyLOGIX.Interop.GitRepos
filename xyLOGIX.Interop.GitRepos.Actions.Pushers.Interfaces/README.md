<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces

## Contents

- [IPusher](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-IPusher 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.IPusher')
  - [Push()](#M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-IPusher-Push 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.IPusher.Push')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-IPusher'></a>
## IPusher `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces

##### Summary

Defines methods and properties for a Pusher.

##### Remarks

Pusher objects push commits to a remote.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-IPusher-Push'></a>
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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown
if the repository currently in use does not have a valid configuration
associated with it. |

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Pushers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Pushers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
