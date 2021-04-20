<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Configuration.Helpers

## Contents

- [GitRepositoryConfigurationHelpers](#T-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers')
  - [_repositoryConfigurations](#F-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-_repositoryConfigurations 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers._repositoryConfigurations')
  - [#cctor()](#M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-#cctor 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers.#cctor')
  - [AttachConfiguration(repository,configuration,useRemote)](#M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-AttachConfiguration-LibGit2Sharp-IRepository,xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean- 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers.AttachConfiguration(LibGit2Sharp.IRepository,xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration,System.Boolean)')
  - [DetachConfiguration(repository)](#M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-DetachConfiguration-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers.DetachConfiguration(LibGit2Sharp.IRepository)')
  - [GetConfiguration(repository)](#M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-GetConfiguration-LibGit2Sharp-IRepository- 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers.GetConfiguration(LibGit2Sharp.IRepository)')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers'></a>
## GitRepositoryConfigurationHelpers `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Helpers

##### Summary

Extension methods to manage repository configurations.

<a name='F-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-_repositoryConfigurations'></a>
### _repositoryConfigurations `constants`

##### Summary

Dictionary that associates repositories to configurations.

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-#cctor'></a>
### #cctor() `method`

##### Summary

Constructs a new instance of
[GitRepositoryConfigurationHelpers](#T-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers 'xyLOGIX.Interop.GitRepos.Configuration.Helpers.GitRepositoryConfigurationHelpers')
and returns a reference to it.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-AttachConfiguration-LibGit2Sharp-IRepository,xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean-'></a>
### AttachConfiguration(repository,configuration,useRemote) `method`

##### Summary

Associates the Git configuration in the specified
`configuration` with this `repository`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to an instance of an object that implements
the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface. |
| configuration | [xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration') | Reference to an instance of an object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface.  In order to be attached, its
[IsActive](#P-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration-IsActive 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration.IsActive')
property must be set to true, and the static method |
| useRemote | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True if the repository is being used with a remote;
false otherwise. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | A required parameter is null. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | An attempt was made to
attach a configuration to this repository that is either invalid or inactive. |

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-DetachConfiguration-LibGit2Sharp-IRepository-'></a>
### DetachConfiguration(repository) `method`

##### Summary

Disassociates a repository configuration object from a repository.

##### Returns

Reference to the instance of the object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
that was detached, or null if there was nothing attached in the first place, or
a problem occurred.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to an instance of an object that implements
the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface that is to have its
configuration detached. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
`repository` is a null reference. |
| [System.InvalidOperationException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidOperationException 'System.InvalidOperationException') | Thrown if the
`repository` does not have an associated configuration
currently. |

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Helpers-GitRepositoryConfigurationHelpers-GetConfiguration-LibGit2Sharp-IRepository-'></a>
### GetConfiguration(repository) `method`

##### Summary

Obtains a reference to the instance of the object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface that is currently associated with this `repository`
, or null if there is none.

##### Returns

Reference to the the instance of the object that implements the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface that is currently associated with this `repository`
, or null if there is none.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| repository | [LibGit2Sharp.IRepository](#T-LibGit2Sharp-IRepository 'LibGit2Sharp.IRepository') | Reference to the instance of the object that
implements the [IGitRepository](#T-LibGit2Sharp-IGitRepository 'LibGit2Sharp.IGitRepository') interface for which
whose corresponding associated configuration should be obtained. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown if the required
`repository` parameter is passed a null reference. |

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Helpers.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Helpers-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
