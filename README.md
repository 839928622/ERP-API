<p align="center">
    <h3 align="center">ERP-API</h3>
    <p align="center">ERP-API is a cross-platform app build by .net core.<p>
</p>

[![Build Status](https://dev.azure.com/jwk8399286220658/ERP-CD-CD%20Organization/_apis/build/status/839928622.ERP-API?branchName=master)](https://dev.azure.com/jwk8399286220658/ERP-CD-CD%20Organization/_build/latest?definitionId=1&branchName=master)

## How to develope
### Before starting
ERP-API is protected by a Identity Service Provider,so you may need to check my another repository  [here](https://github.com/zlzforever/IdentityServer4.Admin)

To develope ERP-API, you need to install the following components:

* Git
* Visual Studio or Visual Studio Code(may need to install multi extentions) 
* [.Net Core 3.1 SDK](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-3.1.301-windows-x64-installer)
* PostMan

I **strongly suggest** using [Visual Studio](https://visualstudio.microsoft.com/) to develope this project.
## How to run
Excute following command in the root directory of this repository to restore all dependencies.

```bash
dotnet restore
```
Excute following command to run and start a debugging server at `localhost:port`.

```bash
dotnet run
```
if you choose Visual Studio as your IDE,then you are good to compeletly igmnore  the bash command above,cuz Visual Studio will take care
all of it for you.after all dependencies were installed, you can click right click current project -> debug ->new instance
## How to contribute
there is one thing you need to know which is  **migration**
when generate a new migration, you need to common out following code in ApplicationDbContext start at line 29
```bash
this._branchIdString = httpContextAccessor.HttpContext.User.FindFirst(CustomizedClaims.BranchId).Value;
this._branchId = Convert.ToInt32(_branchIdString);
```
## I think that's pretty much it  Thank you for reading my README.md

