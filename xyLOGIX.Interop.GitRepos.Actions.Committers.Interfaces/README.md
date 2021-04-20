<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces

## Contents

- [ICommitter](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-ICommitter 'xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.ICommitter')
  - [Commit(commitMessage,addTimestamp)](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-ICommitter-Commit-System-String,System-Boolean- 'xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.ICommitter.Commit(System.String,System.Boolean)')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-ICommitter'></a>
## ICommitter `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces

##### Summary

Defines the methods and properties for a Committer object.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-ICommitter-Commit-System-String,System-Boolean-'></a>
### Commit(commitMessage,addTimestamp) `method`

##### Summary

Creates a commit with the specified `commitMessage`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commitMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.)String containing the commit
commitMessage. |
| addTimestamp | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Set to true to add the timestamp to the
commit message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown
if the repository currently in use does not have a valid configuration
associated with it. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the `commitMessage` is blank for a repository where
it is configured to be mandatory. |

##### Remarks

Use two
newline characters, '\n\n', in the message to separate the short commit message
from a detailed commit message.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
