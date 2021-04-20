<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos

## Contents

- [Resources](#T-xyLOGIX-Interop-GitRepos-Properties-Resources 'xyLOGIX.Interop.GitRepos.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Properties.Resources.ResourceManager')
- [Team](#T-xyLOGIX-Interop-GitRepos-Team 'xyLOGIX.Interop.GitRepos.Team')
  - [#ctor(repository)](#M-xyLOGIX-Interop-GitRepos-Team-#ctor-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Team.#ctor(LibGit2Sharp.IRepository)')
  - [_repository](#F-xyLOGIX-Interop-GitRepos-Team-_repository 'xyLOGIX.Interop.GitRepos.Team._repository')
  - [_repositoryConfigurations](#F-xyLOGIX-Interop-GitRepos-Team-_repositoryConfigurations 'xyLOGIX.Interop.GitRepos.Team._repositoryConfigurations')
  - [Committer](#P-xyLOGIX-Interop-GitRepos-Team-Committer 'xyLOGIX.Interop.GitRepos.Team.Committer')
  - [GitRepositoryConfigurations](#P-xyLOGIX-Interop-GitRepos-Team-GitRepositoryConfigurations 'xyLOGIX.Interop.GitRepos.Team.GitRepositoryConfigurations')
  - [Stager](#P-xyLOGIX-Interop-GitRepos-Team-Stager 'xyLOGIX.Interop.GitRepos.Team.Stager')
  - [Synchronizer](#P-xyLOGIX-Interop-GitRepos-Team-Synchronizer 'xyLOGIX.Interop.GitRepos.Team.Synchronizer')
  - [AddGitRepositoryConfiguration(configuration,setActive)](#M-xyLOGIX-Interop-GitRepos-Team-AddGitRepositoryConfiguration-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean- 'xyLOGIX.Interop.GitRepos.Team.AddGitRepositoryConfiguration(xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration,System.Boolean)')
  - [AttachGitRepositoryToDependencies()](#M-xyLOGIX-Interop-GitRepos-Team-AttachGitRepositoryToDependencies 'xyLOGIX.Interop.GitRepos.Team.AttachGitRepositoryToDependencies')
  - [Commit(commitMessage,addTimestamp,files)](#M-xyLOGIX-Interop-GitRepos-Team-Commit-System-String,System-Boolean,System-String[]- 'xyLOGIX.Interop.GitRepos.Team.Commit(System.String,System.Boolean,System.String[])')
  - [CommitAll(commitMessage,addTimestamp)](#M-xyLOGIX-Interop-GitRepos-Team-CommitAll-System-String,System-Boolean- 'xyLOGIX.Interop.GitRepos.Team.CommitAll(System.String,System.Boolean)')
  - [CommitAllAndPush(commitMessage,addTimestamp)](#M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndPush-System-String,System-Boolean- 'xyLOGIX.Interop.GitRepos.Team.CommitAllAndPush(System.String,System.Boolean)')
  - [CommitAllAndSync(commitMessage,addTimestamp)](#M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndSync-System-String,System-Boolean- 'xyLOGIX.Interop.GitRepos.Team.CommitAllAndSync(System.String,System.Boolean)')
  - [CommitAndPush(commitMessage,addTimestamp,files)](#M-xyLOGIX-Interop-GitRepos-Team-CommitAndPush-System-String,System-Boolean,System-String[]- 'xyLOGIX.Interop.GitRepos.Team.CommitAndPush(System.String,System.Boolean,System.String[])')
  - [CommitAndSync(commitMessage,addTimestamp,files)](#M-xyLOGIX-Interop-GitRepos-Team-CommitAndSync-System-String,System-Boolean,System-String[]- 'xyLOGIX.Interop.GitRepos.Team.CommitAndSync(System.String,System.Boolean,System.String[])')
  - [DeactivateAllConfigurations()](#M-xyLOGIX-Interop-GitRepos-Team-DeactivateAllConfigurations 'xyLOGIX.Interop.GitRepos.Team.DeactivateAllConfigurations')
  - [DeactivateConfiguration(configuration)](#M-xyLOGIX-Interop-GitRepos-Team-DeactivateConfiguration-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration- 'xyLOGIX.Interop.GitRepos.Team.DeactivateConfiguration(xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration)')
  - [DetachGitRepositoryFromDependencies()](#M-xyLOGIX-Interop-GitRepos-Team-DetachGitRepositoryFromDependencies 'xyLOGIX.Interop.GitRepos.Team.DetachGitRepositoryFromDependencies')
  - [Dispose()](#M-xyLOGIX-Interop-GitRepos-Team-Dispose 'xyLOGIX.Interop.GitRepos.Team.Dispose')
  - [SetGitRepositoryConfigurationActive(configuration)](#M-xyLOGIX-Interop-GitRepos-Team-SetGitRepositoryConfigurationActive-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration- 'xyLOGIX.Interop.GitRepos.Team.SetGitRepositoryConfigurationActive(xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration)')
  - [Validate()](#M-xyLOGIX-Interop-GitRepos-Team-Validate 'xyLOGIX.Interop.GitRepos.Team.Validate')

<a name='T-xyLOGIX-Interop-GitRepos-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Team'></a>
## Team `type`

##### Namespace

xyLOGIX.Interop.GitRepos

##### Summary

Main workhorse of this library.

##### Remarks

This object is the C# equivalent of the Changes screen of Visual Studio
Team Explorer. Work with an instance of this class in a using block --
or, be sure to call its
[Dispose](#M-xyLOGIX-Interop-GitRepos-Team-Dispose 'xyLOGIX.Interop.GitRepos.Team.Dispose')
method when
done utilizing it. You must pass an instance of an object that
implements the [IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') interface to its
constructor.

<a name='M-xyLOGIX-Interop-GitRepos-Team-#ctor-LibGit2Sharp-IRepository-'></a>
### #ctor(repository) `constructor`

##### Summary

Constructs a new instance of
[Team](#T-xyLOGIX-Interop-GitRepos-Team 'xyLOGIX.Interop.GitRepos.Team')
and returns a
reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to an instance of an object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository')
interface that allows access
to a Git repository. |

<a name='F-xyLOGIX-Interop-GitRepos-Team-_repository'></a>
### _repository `constants`

##### Summary

Reference to an instance of an object that implements the
[IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository')
interface.

<a name='F-xyLOGIX-Interop-GitRepos-Team-_repositoryConfigurations'></a>
### _repositoryConfigurations `constants`

##### Summary

Collection of references to instances of objects that implement the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface.

<a name='P-xyLOGIX-Interop-GitRepos-Team-Committer'></a>
### Committer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ICommitter](#T-xyLOGIX-Interop-GitRepos-Interfaces-ICommitter 'xyLOGIX.Interop.GitRepos.Interfaces.ICommitter') interface.

<a name='P-xyLOGIX-Interop-GitRepos-Team-GitRepositoryConfigurations'></a>
### GitRepositoryConfigurations `property`

##### Summary

Gets a reference to a read-only collection of references to
instances of objects that implement the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface.

<a name='P-xyLOGIX-Interop-GitRepos-Team-Stager'></a>
### Stager `property`

##### Summary

Gets a reference to an instance of an object that implements the
[IStager](#T-xyLOGIX-Interop-GitRepos-Interfaces-IStager 'xyLOGIX.Interop.GitRepos.Interfaces.IStager') interface.

<a name='P-xyLOGIX-Interop-GitRepos-Team-Synchronizer'></a>
### Synchronizer `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ISynchronizer](#T-xyLOGIX-Interop-GitRepos-Interfaces-ISynchronizer 'xyLOGIX.Interop.GitRepos.Interfaces.ISynchronizer')
interface.

<a name='M-xyLOGIX-Interop-GitRepos-Team-AddGitRepositoryConfiguration-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean-'></a>
### AddGitRepositoryConfiguration(configuration,setActive) `method`

##### Summary

Adds an instance of an object that implements the
[IGitRepositoryConfiguration](#T-xyLGOIX-Interop-Git-Interfaces-IGitRepositoryConfiguration 'xyLGOIX.Interop.Git.Interfaces.IGitRepositoryConfiguration')
interface to the list that this object maintains and optionally sets
it active.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration') | Reference to an instance of an object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface that is to be added to the list of configurations. |
| setActive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True to set the new configuration as active; false otherwise. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the `configuration` parameter has as null
reference. |

##### Remarks

Merely setting the `configuration` object's
IsActive property to be true is not enough to actually associate the
configuration with the repository this Team is using. To associate
it, either pass true for the `setActive` parameter
(which is the default), or call the
[SetGitRepositoryConfigurationActive](#M-xyLOGIX-Interop-GitRepos-Team-SetGitRepositoryConfigurationActive 'xyLOGIX.Interop.GitRepos.Team.SetGitRepositoryConfigurationActive')
next. If this method's `setActive` parameter is set
to true, then this method will set the added configuration active
for the caller.

<a name='M-xyLOGIX-Interop-GitRepos-Team-AttachGitRepositoryToDependencies'></a>
### AttachGitRepositoryToDependencies() `method`

##### Summary

Associates the instance of the object in the _repository field with
the Committer, Stager, and Synchronizer.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
[Committer](#P-xyLOGIX-Interop-GitRepos-Team-Committer 'xyLOGIX.Interop.GitRepos.Team.Committer')
,
[Stager](#P-xyLOGIX-Interop-GitRepos-Team-Stager 'xyLOGIX.Interop.GitRepos.Team.Stager')
, or the
[Synchronizer](#P-xyLOGIX-Interop-GitRepos-Team-Synchronizer 'xyLOGIX.Interop.GitRepos.Team.Synchronizer')
property are `null`. |

<a name='M-xyLOGIX-Interop-GitRepos-Team-Commit-System-String,System-Boolean,System-String[]-'></a>
### Commit(commitMessage,addTimestamp,files) `method`

##### Summary

Stages all the modified (but not ignored) files in
`files`
, and then creates a new Commit with the specified
`commitMessage` and optional timestamp.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commitMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.)String containing the commit commitMessage. |
| addTimestamp | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Set to true to add the timestamp to the commit message. |
| files | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Collection of path names, either absolute or relative, of files to
be staged as part of this commit. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

##### Remarks

Use two newline characters, '\n\n', in the message to separate the
short commit message from a detailed commit message. This method
simply calls the
[CommitAll](#M-xyLOGIX-Interop-GitRepos-Team-CommitAll 'xyLOGIX.Interop.GitRepos.Team.CommitAll')
method
if no `files` are specified.

<a name='M-xyLOGIX-Interop-GitRepos-Team-CommitAll-System-String,System-Boolean-'></a>
### CommitAll(commitMessage,addTimestamp) `method`

##### Summary

Stages all the modified files in the working directory, except
ignored files, and then creates a new Commit with the specified
`commitMessage` and optional timestamp.

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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

##### Remarks

Use two newline characters, '\n\n', in the message to separate the
short commit message from a detailed commit message.

<a name='M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndPush-System-String,System-Boolean-'></a>
### CommitAllAndPush(commitMessage,addTimestamp) `method`

##### Summary

Stages all items that are marked as modified in the working tree --
except ignored items -- and then pushes the commit to the remote.

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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

<a name='M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndSync-System-String,System-Boolean-'></a>
### CommitAllAndSync(commitMessage,addTimestamp) `method`

##### Summary

Stages all items that are marked as modified in the working tree --
except ignored items -- and then synchronizes (i.e., pulls, then
pushes) the commit to the remote.

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
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

<a name='M-xyLOGIX-Interop-GitRepos-Team-CommitAndPush-System-String,System-Boolean,System-String[]-'></a>
### CommitAndPush(commitMessage,addTimestamp,files) `method`

##### Summary

Stages all the modified (but not ignored) files in the
`files`
collection, creates a new Commit with the specified
`commitMessage` and optional timestamp, and then
pushes the Commit to the remote.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commitMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.)String containing the commit commitMessage. |
| addTimestamp | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Set to true to add the timestamp to the commit message. |
| files | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Collection of path names, either absolute or relative, of files to
be staged as part of this commit. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

##### Remarks

Use two newline characters, '\n\n', in the message to separate the
short commit message from a detailed commit message. This method
simply calls the
[CommitAllAndPush](#M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndPush 'xyLOGIX.Interop.GitRepos.Team.CommitAllAndPush')
method if no `files` are specified.

<a name='M-xyLOGIX-Interop-GitRepos-Team-CommitAndSync-System-String,System-Boolean,System-String[]-'></a>
### CommitAndSync(commitMessage,addTimestamp,files) `method`

##### Summary

Stages all the modified (but not ignored) files in the
`files`
collection, and then creates a new Commit with the
specified and optional timestamp,
and then synchronizes (i.e., pulls and then pushes) the Commit(s) to
the remote.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commitMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Required.)String containing the commit commitMessage. |
| addTimestamp | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | (Optional.) Set to true to add the timestamp to the commit message. |
| files | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Collection of path names, either absolute or relative, of files to
be staged as part of this commit. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException') | Thrown if the
[AttachGitRepository](#M-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryAction-AttachGitRepository 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryAction.AttachGitRepository')
method has not been called. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException') | An active and valid
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
is not associated with the repository. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown when the repository in use is configured to make commit
messages mandatory, yet the `commitMessage` is blank. |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |

##### Remarks

Use two newline characters, '\n\n', in the message to separate the
short commit message from a detailed commit message. This method
simply calls the
[CommitAllAndSync](#M-xyLOGIX-Interop-GitRepos-Team-CommitAllAndSync 'xyLOGIX.Interop.GitRepos.Team.CommitAllAndSync')
method if no `files` are specified.

<a name='M-xyLOGIX-Interop-GitRepos-Team-DeactivateAllConfigurations'></a>
### DeactivateAllConfigurations() `method`

##### Summary

Deactivates all this team's Git configurations.

##### Parameters

This method has no parameters.

##### Remarks

After this method is called, the
[SetGitRepositoryConfigurationActive](#M-xyLOGIX-Interop-GitRepos-Team-SetGitRepositoryConfigurationActive 'xyLOGIX.Interop.GitRepos.Team.SetGitRepositoryConfigurationActive')
method must be called prior to any Git methods being called again.

<a name='M-xyLOGIX-Interop-GitRepos-Team-DeactivateConfiguration-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-'></a>
### DeactivateConfiguration(configuration) `method`

##### Summary

Deactivates the specified repository `configuration`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration') | Reference to an instance of an object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface that is to be deactivated. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required parameter, `configuration`,
is passed a `null` value. |

##### Remarks

This method exists purely for fluent use in LINQ queries.

<a name='M-xyLOGIX-Interop-GitRepos-Team-DetachGitRepositoryFromDependencies'></a>
### DetachGitRepositoryFromDependencies() `method`

##### Summary

Disassociates the instance of the object in the _repository field
from the Committer, Stager, and Synchronizer.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
[Committer](#P-xyLOGIX-Interop-GitRepos-Team-Committer 'xyLOGIX.Interop.GitRepos.Team.Committer')
,
[Stager](#P-xyLOGIX-Interop-GitRepos-Team-Stager 'xyLOGIX.Interop.GitRepos.Team.Stager')
, or the
[Synchronizer](#P-xyLOGIX-Interop-GitRepos-Team-Synchronizer 'xyLOGIX.Interop.GitRepos.Team.Synchronizer')
property are `null`. |

<a name='M-xyLOGIX-Interop-GitRepos-Team-Dispose'></a>
### Dispose() `method`

##### Summary

Performs application-defined tasks associated with freeing,
releasing, or resetting unmanaged resources.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Team-SetGitRepositoryConfigurationActive-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-'></a>
### SetGitRepositoryConfigurationActive(configuration) `method`

##### Summary

Sets the specified `configuration` as active, and
associates it with the GitRepository object that this Team is using.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration') | Reference to the instance of the object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface that is to be made active. This is also attached to the
repository currently in use. |

<a name='M-xyLOGIX-Interop-GitRepos-Team-Validate'></a>
### Validate() `method`

##### Summary

This method runs validation rules against the
[GitRepositoryConfigurations](#P-xyLOGIX-Interop-GitRepos-Team-GitRepositoryConfigurations 'xyLOGIX.Interop.GitRepos.Team.GitRepositoryConfigurations')
collection.

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException') | Thrown if a validation error is encountered due to improper
configuration of this Team. |
