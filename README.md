# AspNetCore Curl Middleware Package
Captures the ASP.NETCore HTTP Request and converts it as CURL file.

# Use Case 
As a back-end developer we would come across with different errors during runtime across multiple environments like QA, Staging, Production etc...In the modern era of micro-services the effort that we put to reproduce the same request and test in our local system has become a tedious process. In order to reduce the effort spent in reproducing a issue we could log the HTTP Request object as a curl request and save the request as files. These files can be pulled back into Postman or any other API testing tools and can be used to reproduce the issue a lot quicker than manually framing it.

# Usage
Install the package created after the build or install the package via nuget using the following command

``` Install-Package AspNetCoreCurlMiddleware -Version 1.0.0 ``` 

in your .NET Project.

# Code
Add services needed for the middleware and initialize the parameters needed for the IRequestBuilder.
Add the extension methods as part of **ConfigureServices**  and **Configure** method in **Startup.cs**

```
services.AddSaveAsCurlMiddlewareServices(new Middleware.Models.SaveRequestOptions { LogPath = "request", SaveRequest = true });
```

```
app.UseSaveAsCurlMiddleware();
```

The SaveRequestOptions carries the input parameters for the curl builder you can customize the curl builder by extending the classes for your needs.

<a href="https://www.buymeacoffee.com/hakunamatatain" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# Contributions
Contributions & ideas for extending the projects are welcome.
