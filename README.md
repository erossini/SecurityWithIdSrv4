# Implement security workflow with Identity Server and C#
The goal of this post is to implement security workflow with [Identity Server 4](https://www.puresourcecode.com/?s=identity+server) and [C#](https://www.puresourcecode.com/category/dotnet/csharp/) among projects and services. With a bunch of examples, I'm going to show, practically, how to do it.

Generally speaking, I consider two groups of connections or applications:
- platform apps, APIs, and services</strong> are trusted because under my direct control
- external networks and applications</strong> such as client connections

![PureSourceCode https://www.puresourcecode.com](https://www.puresourcecode.com/wp-content/uploads/2020/10/Security-Workflow-IdentityServer.jpg)

## Projects

### IdentityServerHost

This ASP.NET Core 2.0 application hosts the IdentityServer.
All configurations like users, APIs and clients are static in the [SampleConfig.cs](src/Platform-IdentityServerHost/SampleConfig.cs) file.

The IdentityServer is registered inside of [Startup.cs](src/Platform-IdentityServerHost/Startup.cs)

The sources inside the [Quickstart](src/Platform-IdentityServerHost/Quickstart) are taken from https://github.com/IdentityServer/IdentityServer4.Quickstart.UI without modifications.

### BaseApiSDK

This projects provides basic stuff for accessing an API with the help of a SDK.
In a productive environment this would be a NuGet package.

### TodoApi

This ASP.NET Core 2.0 application hosts the demo API of todos.
All configurations like users, APIs and clients are static in the [ApiSampleOptions.cs](src/Platform-TasksApi/ApiSampleOptions.cs) file.

### TodoApiSdk

This projects provides a client `TodoApiClient` for accessing the TodoApi.
It gives you a client for authentication and receiving typed data.

In a productive environment this would be a NuGet package.

### PortalWebApp

This ASP.NET Core 2.0 application represents the "Portal Web Application" the user interacts with.

You have a navigation element to receive the tasks from the TodoApi with the help of the TodoApiSdk and you have a navigation element to watch your claims.

Both clicks will redirects you to the IdentityServerHost where you have to log in.
Afterwards to will be redirected to this application.

### ExternalWebApp

This ASP.NET Core 2.0 application represents an "External Web Application" which is not part of the platform and maybe run by an external company.

This application also provides a navigation element for tasks and claims but after the login the user has to accept the access for this application via via [IdentityServer Consent](http://docs.identityserver.io/en/release/topics/consent.html) as shown above.

### AdminConsoleClient

This is just a simple console application with a usual name based on .NET Core 2.0.
It represents a simple client which calls the API with the TodoApiSdk and hard coded user credentials.

In a real world scenario this could be any .NET desktop/server/mobile application.

# Conclusion

The explanation of this code is on my blog [PureSourceCode](https://www.puresourcecode.com/dotnet/net-core/implement-security-workflow-with-identity-server). If you want to ask or comment this code, please use my [forum](https://www.puresourcecode.com/forum/).
