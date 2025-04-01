# GuiStracini.SDKBuilder

An SDK framework designed to streamline the creation of C# SDKs for consuming generic REST APIs.

![GuiStracini.SDKBuilder logo](https://raw.githubusercontent.com/guibranco/GuiStracini.SDKBuilder/main/logo.png)

[![GitHub license](https://img.shields.io/github/license/guibranco/GuiStracini.SDKBuilder)](https://github.com/guibranco/GuiStracini.SDKBuilder)
[![Time tracker](https://wakatime.com/badge/github/guibranco/GuiStracini.SDKBuilder.svg)](https://wakatime.com/badge/github/guibranco/GuiStracini.SDKBuilder)

---

## 🚀 CI/CD Status

| Build Status | Last Commit | Tests | Coverage | Code Smells | LoC |
|--------------|-------------|-------|----------|-------------|-----|
| [![Build status](https://ci.appveyor.com/api/projects/status/21n1ykfup5qpx6gy/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder/branch/main) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/GuiStracini.SDKBuilder/main)](https://github.com/guibranco/GuiStracini.SDKBuilder) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/guistracini-sdkbuilder/main?compact_message)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder/branch/main/tests) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=coverage&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=code_smells&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=ncloc&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) |

---

## 🛠️ Code Quality

[![DeepSource](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder.svg/?label=active+issues&show_trend=true&token=SUN_b7NV-uOGUMWnxFFFUFb9)](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder/?ref=repository-badge)

[![Codacy Grade](https://app.codacy.com/project/badge/Grade/572455795b584087bd465974d2dce1a4)](https://www.codacy.com/gh/guibranco/GuiStracini.SDKBuilder/dashboard)
[![Codacy Coverage](https://app.codacy.com/project/badge/Coverage/572455795b584087bd465974d2dce1a4)](https://www.codacy.com/gh/guibranco/GuiStracini.SDKBuilder/dashboard)

[![Codecov](https://codecov.io/gh/guibranco/GuiStracini.SDKBuilder/branch/main/graph/badge.svg?token=pFvFFTF2bb)](https://codecov.io/gh/guibranco/GuiStracini.SDKBuilder)
[![CodeFactor](https://www.codefactor.io/repository/github/guibranco/GuiStracini.SDKBuilder/badge)](https://www.codefactor.io/repository/github/guibranco/GuiStracini.SDKBuilder)

---

## 📦 Installation

### GitHub Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/GuiStracini.SDKBuilder.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder/releases)  
[![GitHub downloads](https://img.shields.io/github/downloads/guibranco/GuiStracini.SDKBuilder/total.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder)

Download the latest version from the [Release Page](https://github.com/GuiBranco/GuiStracini.SDKBuilder/releases).

### NuGet Package

| Package | Version | Downloads |
|---------|---------|-----------|
| **GuiStracini.SDKBuilder** | [![NuGet Version](https://img.shields.io/nuget/v/GuiStracini.SDKBuilder.svg?style=flat)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/) | [![NuGet Downloads](https://img.shields.io/nuget/dt/GuiStracini.SDKBuilder.svg?style=flat)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/) |

---

## 📖 Overview

GuiStracini.SDKBuilder simplifies SDK development for REST APIs using WebAPI2 conventions. It provides a **ServiceFactory** class that implements the **IServiceFactory** interface, including methods for **Get, Post, Put, Delete, Head, and Upload** operations.

The library leverages self-convention and custom attributes to generate intelligent endpoints and handle API requests efficiently.

### 🏗 Using `IServiceFactory`, `IRequestBase`, and `IResponseBase`

#### 🔧 IServiceFactory Example:
```csharp
IServiceFactory serviceFactory = new ServiceFactory();
var response = serviceFactory.Get<MyResponseType>("/api/resource");
```

#### 📤 IRequestBase Example:
```csharp
public class MyRequest : IRequestBase {
    public string Property { get; set; }
}
```

#### 📥 IResponseBase Example:
```csharp
public class MyResponse : IResponseBase {
    public string Result { get; set; }
}
```

---

## 🏗️ Creating a New SDK

To build a new SDK, you need:
- API endpoints
- Request/response object structures
- Authentication flow details

**🔒 Note:** Currently, the package supports **Basic Authorization** (via HTTP headers or JWT). OAuth/OAuth2 is not natively supported, but you can extend it. Contributions via PR are welcome!

---

## 📝 License

This project is licensed under the **MIT License**. See the [LICENSE](https://github.com/guibranco/GuiStracini.SDKBuilder/blob/main/LICENSE) file for details.

---

## 📬 Contact & Contributions

If you have suggestions, bug reports, or feature requests, feel free to open an [issue](https://github.com/guibranco/GuiStracini.SDKBuilder/issues) or submit a PR.

Happy coding! 🚀

