<a name='assembly'></a>
# xyLOGIX.Interop.GitRepos.Configuration

## Contents

- [GitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration')
  - [#ctor()](#M-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-#ctor 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.#ctor')
  - [Email](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-Email 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.Email')
  - [HasRemote](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-HasRemote 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.HasRemote')
  - [IsActive](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-IsActive 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.IsActive')
  - [IsCommitMessageMandatory](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-IsCommitMessageMandatory 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.IsCommitMessageMandatory')
  - [Name](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-Name 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.Name')
  - [RemoteName](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemoteName 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.RemoteName')
  - [RemotePassword](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemotePassword 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.RemotePassword')
  - [RemoteUserName](#P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemoteUserName 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration.RemoteUserName')
- [Resources](#T-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources 'xyLOGIX.Interop.GitRepos.Configuration.Properties.Resources')
  - [Culture](#P-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources-Culture 'xyLOGIX.Interop.GitRepos.Configuration.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources-ResourceManager 'xyLOGIX.Interop.GitRepos.Configuration.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration'></a>
## GitRepositoryConfiguration `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration

##### Summary

GitRepositoryConfiguration for a committer and remote.

<a name='M-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of
[GitRepositoryConfiguration](#T-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration 'xyLOGIX.Interop.GitRepos.Configuration.GitRepositoryConfiguration')
and returns a reference to it.

##### Parameters

This constructor has no parameters.

##### Remarks

This constructor sets default values for some of the properties.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-Email'></a>
### Email `property`

##### Summary

Gets or sets a string containing the email address or handle of the committer.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-HasRemote'></a>
### HasRemote `property`

##### Summary

Gets or sets a value that specifies whether this repository has a remote.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-IsActive'></a>
### IsActive `property`

##### Summary

Gets or sets a value indicating whether this is the active
repositoryConfiguration --
like Highlander, there can be only one!

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-IsCommitMessageMandatory'></a>
### IsCommitMessageMandatory `property`

##### Summary

Gets or sets a value indicating whether a non-blank commit message is
mandatory.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-Name'></a>
### Name `property`

##### Summary

Gets or sets a string containing the name of the committer.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemoteName'></a>
### RemoteName `property`

##### Summary

Gets or sets name of the remote.  Usually set to 'origin' by default.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemotePassword'></a>
### RemotePassword `property`

##### Summary

Gets or sets a string containing the password utilized to sign in to the
remote.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-GitRepositoryConfiguration-RemoteUserName'></a>
### RemoteUserName `property`

##### Summary

Gets or sets a string containing the username utilized to sign in to the
remote.

<a name='T-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Interop.GitRepos.Configuration.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Interop-GitRepos-Configuration-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
