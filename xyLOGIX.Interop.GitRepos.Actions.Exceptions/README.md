<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Actions.Exceptions

## Contents

- [GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException.#ctor')
- [GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException-#ctor 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException.#ctor')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.Properties.Resources.ResourceManager')
- [TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException')
  - [#ctor(team,message)](#M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException-#ctor-xyLOGIX-Interop-GitRepos-Interfaces-ITeam,System-String- 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException.#ctor(xyLOGIX.Interop.GitRepos.Interfaces.ITeam,System.String)')
  - [Team](#P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException-Team 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException.Team')

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException'></a>
## GitRepositoryNotAttachedException `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Exceptions

##### Summary

An exception object that informs the caller that an object that implements the
[IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface is not attached to the
object is should be.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[GitRepositoryNotAttachedException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotAttachedException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotAttachedException')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException'></a>
## GitRepositoryNotConfiguredException `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Exceptions

##### Summary

Exception type used to inform the developer that the Git repository was
not configured properly before a repository action, such as Commit,
Stage, Pull, or Push, was tried on it.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[GitRepositoryNotConfiguredException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-GitRepositoryNotConfiguredException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.GitRepositoryNotConfiguredException')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Exceptions.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException'></a>
## TeamConfigurationException `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Actions.Exceptions

##### Summary

Exception object to be thrown in the event that a Team object is not
properly configured.

<a name='M-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException-#ctor-xyLOGIX-Interop-GitRepos-Interfaces-ITeam,System-String-'></a>
### #ctor(team,message) `constructor`

##### Summary

Constructs a new instance of
[TeamConfigurationException](#T-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException 'xyLOGIX.Interop.GitRepos.Actions.Exceptions.TeamConfigurationException')
and returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| team | [xyLOGIX.Interop.GitRepos.Interfaces.ITeam](#T-xyLOGIX-Interop-GitRepos-Interfaces-ITeam 'xyLOGIX.Interop.GitRepos.Interfaces.ITeam') | (Required.) Reference to an instance of an object that implements
the [ITeam](#T-xyLOGIX-Interop-GitRepos-Interfaces-ITeam 'xyLOGIX.Interop.GitRepos.Interfaces.ITeam')
interface. This object represents the Team that this exception is
talking about. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional.) Message, if any, to be added to this exception's default message. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the `team` parameter is passed a null reference. |

<a name='P-xyLOGIX-Interop-GitRepos-Actions-Exceptions-TeamConfigurationException-Team'></a>
### Team `property`

##### Summary

Gets a reference to an instance of an object that implements the
[ITeam](#T-xyLOGIX-Interop-GitRepos-Interfaces-ITeam 'xyLOGIX.Interop.GitRepos.Interfaces.ITeam')
interface that represents the Team this exception is talking about.
