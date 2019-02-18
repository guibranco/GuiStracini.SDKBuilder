# GBStracini.SDKBuilder

[![Build status](https://ci.appveyor.com/api/projects/status/21n1ykfup5qpx6gy?svg=true)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder)
[![GuiStracini.SDKBuilder NuGet Version](https://img.shields.io/nuget/v/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![GuiStracini.SDKBuilder NuGet Downloads](https://img.shields.io/nuget/dt/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![Github All Releases](https://img.shields.io/github/downloads/guibranco/GuiStracini.SDKBuilder/total.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder)
![Last release](https://img.shields.io/github/release-date/guibranco/guistracini.sdkbuilder.svg?style=flat)

[![codecov](https://codecov.io/gh/guibranco/guistracini.sdkbuilder/branch/master/graph/badge.svg)](https://codecov.io/gh/guibranco/guistracini.sdkbuilder)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)

A SDK framework that helps create a C# SDK project for consuming a generic REST API

<img src="https://raw.githubusercontent.com/guibranco/GuiStracini.SDKBuilder/master/GuiStracini.SDKBuilder.png" alt="GuiStracini.SDKBuilder" width="150" height="150">

----------

NuGet package: https://www.nuget.org/packages/GuiStracini.SDKBuilder
```ps
Install-Package GuiStracini.SDKBuilder
```

This package allows the easy creation of a SDK (Sofware Development Kit) for consuming a REST API based on WebAPI2 conventions.
The ServiceFactory class implements the IServiceFactory interface, having the methods Get, Post, Put, Delete, Head and Upload and uses a self convetion and custom attributes to generate smart endpoints and do requests.

----------

## Creating a new SDK ##

To create a new SDK, first acquire the API endpoints, the objects (in out) properties and the authorization flow.
**Currently, this package only supports basic authorization** (via HTTP headers, or JWT-like. OAuth/OAuth2 is not supported by default, but can be implemented by yourself or in a future version, let me know - via PR - if you make some progress on that!)


