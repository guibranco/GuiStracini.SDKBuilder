# GBStracini.SDKBuilder

[![Build status](https://ci.appveyor.com/api/projects/status/21n1ykfup5qpx6gy?svg=true)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder)
[![GuiStracini.SDKBuilder NuGet Version](https://img.shields.io/nuget/v/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![GuiStracini.SDKBuilder NuGet Downloads](https://img.shields.io/nuget/dt/GuiStracini.SDKBuilder.svg)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/)
[![Github All Releases](https://img.shields.io/github/downloads/guibranco/GuiStracini.SDKBuilder/total.svg?style=plastic)](https://github.com/guibranco/GuiStracini.SDKBuilder)

A SDK framework that helps create a C# SDK project for consuming a generic REST API

[![GuiStracini.SDKBuilder](https://raw.githubusercontent.com/guibranco/GuiStracini.SDKBuilder/master/GuiStracini.SDKBuilder.png)]

----------

NuGet package: https://www.nuget.org/packages/GuiStracini.SDKBuilder
```ps
Install-Package GuiStracini.SDKBuilder
```

This package allows the creation of a SDK (Sofware Development Kit) for consuming a REST API based on WebAPI2 conventions.
The ServiceFactory class has the methods Get, Post, Put, Delete, Head and Upload and uses a convetion and custom attributes to generate smart endpoints and do requests.