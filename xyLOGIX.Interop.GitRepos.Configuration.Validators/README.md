<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Configuration.Validators

## Contents

- [GitRepositoryConfigurationValidator](#T-xyLOGIX-Interop-GitRepos-Configuration-Validators-GitRepositoryConfigurationValidator 'xyLOGIX.Interop.GitRepos.Configuration.Validators.GitRepositoryConfigurationValidator')
  - [IsValid(configuration,hasRemote)](#M-xyLOGIX-Interop-GitRepos-Configuration-Validators-GitRepositoryConfigurationValidator-IsValid-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean- 'xyLOGIX.Interop.GitRepos.Configuration.Validators.GitRepositoryConfigurationValidator.IsValid(xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration,System.Boolean)')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources 'xyLOGIX.Interop.GitRepos.Configuration.Validators.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Configuration.Validators.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Configuration.Validators.Properties.Resources.ResourceManager')
- [TeamConfigurationValidator](#T-xyLOGIX-Interop-GitRepos-Configuration-Validators-TeamConfigurationValidator 'xyLOGIX.Interop.GitRepos.Configuration.Validators.TeamConfigurationValidator')
  - [HasOnlyOneActiveRepoConfig(configurations)](#M-xyLOGIX-Interop-GitRepos-Configuration-Validators-TeamConfigurationValidator-HasOnlyOneActiveRepoConfig-System-Collections-Generic-IReadOnlyCollection{xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration}- 'xyLOGIX.Interop.GitRepos.Configuration.Validators.TeamConfigurationValidator.HasOnlyOneActiveRepoConfig(System.Collections.Generic.IReadOnlyCollection{xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration})')

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Validators-GitRepositoryConfigurationValidator'></a>
## GitRepositoryConfigurationValidator `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Validators

##### Summary

Methods to validate the values of the properties of objects that are instances
of those which implement the
[IGitRepositoryGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryGitRepositoryConfiguration')
interface.

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Validators-GitRepositoryConfigurationValidator-IsValid-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration,System-Boolean-'></a>
### IsValid(configuration,hasRemote) `method`

##### Summary

Determines whether the specified `configuration`
object has
valid values for its properties.  By valid we mean to say, can be utilized with
either a local or a local-and-remote repository(ies).

##### Returns

True if the values of the properties are valid; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration') | Reference to an instance of an object that implements the
[GitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-GitRepositoryConfigurations-GitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.GitRepositoryConfigurations.GitRepositoryConfiguration')
, the
values of whose properties are to be checked. |
| hasRemote | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | True if the remote user name and remote password should
be checked; false otherwise. |

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Validators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Validators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Validators-TeamConfigurationValidator'></a>
## TeamConfigurationValidator `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Validators

##### Summary

Methods to validate team configurations.

##### Remarks

Examples of such validation include making sure that a Team has only
one (1) active GitRepository Configuration at a given time.

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-Validators-TeamConfigurationValidator-HasOnlyOneActiveRepoConfig-System-Collections-Generic-IReadOnlyCollection{xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration}-'></a>
### HasOnlyOneActiveRepoConfig(configurations) `method`

##### Summary

Determines whether the collection of
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
s passed in the `configurations` parameter contains exactly
one element that is marked as active.

##### Returns

True if the collection contains exactly one instance of an active
configuration; false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurations | [System.Collections.Generic.IReadOnlyCollection{xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IReadOnlyCollection 'System.Collections.Generic.IReadOnlyCollection{xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration}') | Collection of references to objects that implement
the
[IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Interfaces.IGitRepositoryConfiguration')
interface. |
