# GuiStracini.SDKBuilder

[![Build status](https://ci.appveyor.com/api/projects/status/21n1ykfup5qpx6gy/branch/master?svg=true)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder)
[![GuiStracini.SDKBuilder NuGet Version](https://img.shields.io/nuget/v/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![GuiStracini.SDKBuilder NuGet Downloads](https://img.shields.io/nuget/dt/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![Github All Releases](https://img.shields.io/github/downloads/guibranco/GuiStracini.SDKBuilder/total.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder)
[![Last release](https://img.shields.io/github/release-date/guibranco/guistracini.sdkbuilder.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder/releases)

A SDK framework that helps create a C# SDK project for consuming a generic REST API

<img src="https://raw.githubusercontent.com/guibranco/GuiStracini.SDKBuilder/master/logo.png" alt="GuiStracini.SDKBuilder" width="150" height="150">

---

## Installation

NuGet package: [https://www.nuget.org/packages/GuiStracini.SDKBuilder](https://www.nuget.org/packages/GuiStracini.SDKBuilder)

```ps

Install-Package GuiStracini.SDKBuilder

```

This package allows the easy creation of a SDK (Sofware Development Kit) for consuming a REST API based on WebAPI2 conventions.
The ServiceFactory class implements the IServiceFactory interface, having the methods Get, Post, Put, Delete, Head and Upload and uses a self convetion and custom attributes to generate smart endpoints and do requests.

---

## Creating a new SDK

To create a new SDK, first acquire the API endpoints, the objects (in out) properties and the authorization flow.
**Currently, this package only supports basic authorization** (via HTTP headers, or JWT-like. OAuth/OAuth2 is not supported by default, but can be implemented by yourself or in a future version, let me know - via PR - if you make some progress on that!)

---

## TODO

Implement the missing methods
