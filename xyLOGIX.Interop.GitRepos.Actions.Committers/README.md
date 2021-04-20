<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Committers

## Contents

- [Committer](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.#ctor')
  - [Instance](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-Instance 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.Instance')
  - [TheTimestamp](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-TheTimestamp 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.TheTimestamp')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-#cctor 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.#cctor')
  - [Commit(commitMessage,addTimestamp)](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-Commit-System-String,System-Boolean- 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.Commit(System.String,System.Boolean)')
  - [OnCommitCompleted()](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitCompleted 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.OnCommitCompleted')
  - [OnCommitFailed(e)](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitFailed-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs- 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.OnCommitFailed(xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs)')
  - [OnCommitStarted()](#M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitStarted 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer.OnCommitStarted')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Committers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Committers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Committers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer'></a>
## Committer `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers

##### Summary

Commits staged items to a Git repository.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-#ctor'></a>
### #ctor() `constructor`

##### Summary

Empty, protected constructor to prohibit direct allocation of this class.

##### Parameters

This constructor has no parameters.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-Instance'></a>
### Instance `property`

##### Summary

Gets a reference to the one and only instance of
[Committer](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer 'xyLOGIX.Interop.GitRepos.Actions.Committers.Committer')
.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-TheTimestamp'></a>
### TheTimestamp `property`

##### Summary

Gets a timestamp string for commits. The string shows the local date
and time in UTC.

##### Returns

String containing the timestamp.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-#cctor'></a>
### #cctor() `method`

##### Summary

Empty, static constructor to prohibit direct allocation of this class.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-Commit-System-String,System-Boolean-'></a>
### Commit(commitMessage,addTimestamp) `method`

##### Summary

Creates a commit with the specified `commitMessage`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commitMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.)String containing the commit commitMessage. |
| addTimestamp | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Set to true to add the timestamp to the commit message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | Thrown if the repository currently in use does not have a valid
configuration associated with it. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the `commitMessage` is blank for a
repository where it is configured to be mandatory. |

##### Remarks

Use two newline characters, '\n\n', in the message to separate the
short commit message from a detailed commit message.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitCompleted'></a>
### OnCommitCompleted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Committers-Committer-CommitCompleted              'xyLOGIX.Interop.GitRepos.Committers.Committer.CommitCompleted             ')
event.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitFailed-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs-'></a>
### OnCommitFailed(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Committers-Committer-CommitFailed              'xyLOGIX.Interop.GitRepos.Committers.Committer.CommitFailed             ')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Actions-Committers-Events-CommitFailedEventArgs 'xyLOGIX.Interop.GitRepos.Actions.Committers.Events.CommitFailedEventArgs') | A
[CommitFailedEventArgs](#T-xyLOGIX-Interop-GitRepos-Events-CommitFailedEventArgs 'xyLOGIX.Interop.GitRepos.Events.CommitFailedEventArgs')
that contains the event data. |

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Committers-Committer-OnCommitStarted'></a>
### OnCommitStarted() `method`

##### Summary

Raises the
[](#E-xyLOGIX-Interop-GitRepos-Committers-Committer-CommitStarted              'xyLOGIX.Interop.GitRepos.Committers.Committer.CommitStarted             ')
event.

##### Parameters

This method has no parameters.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Committers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Committers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
