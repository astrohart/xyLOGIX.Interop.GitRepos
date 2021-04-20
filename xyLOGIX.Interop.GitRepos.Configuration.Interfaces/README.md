<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Configuration.Interfaces

## Contents

- [IGitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration')
  - [Email](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-Email 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.Email')
  - [HasRemote](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-HasRemote 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.HasRemote')
  - [IsActive](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-IsActive 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.IsActive')
  - [IsCommitMessageMandatory](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-IsCommitMessageMandatory 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.IsCommitMessageMandatory')
  - [Name](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-Name 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.Name')
  - [RemoteName](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemoteName 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.RemoteName')
  - [RemotePassword](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemotePassword 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.RemotePassword')
  - [RemoteUserName](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemoteUserName 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.IGitRepositoryConfiguration.RemoteUserName')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Configuration.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration'></a>
## IGitRepositoryConfiguration `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Interfaces

##### Summary

Defines methods and properties for a GitRepositoryConfiguration POCO.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-Email'></a>
### Email `property`

##### Summary

Gets or sets a string containing the email address or handle of the committer.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-HasRemote'></a>
### HasRemote `property`

##### Summary

Gets or sets a value that specifies whether this repository has a remote.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-IsActive'></a>
### IsActive `property`

##### Summary

Gets or sets a value indicating whether this is the active
repositoryConfiguration --
like Highlander, there can be only one!

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-IsCommitMessageMandatory'></a>
### IsCommitMessageMandatory `property`

##### Summary

Gets or sets a value indicating whether a non-blank commit message is
mandatory.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-Name'></a>
### Name `property`

##### Summary

Gets or sets a string containing the name of the committer.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemoteName'></a>
### RemoteName `property`

##### Summary

Gets or sets name of the remote.  Usually set to 'origin' by default.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemotePassword'></a>
### RemotePassword `property`

##### Summary

Gets or sets a string containing the password utilized to sign in to the
remote.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-IGitRepositoryConfiguration-RemoteUserName'></a>
### RemoteUserName `property`

##### Summary

Gets or sets a string containing the username utilized to sign in to the
remote.

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
