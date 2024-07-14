# GuiStracini.SDKBuilder

An SDK framework that helps create a C# SDK project for consuming a generic REST API

[![GitHub license](https://img.shields.io/github/license/guibranco/GuiStracini.SDKBuilder)](https://github.com/guibranco/GuiStracini.SDKBuilder)
[![Time tracker](https://wakatime.com/badge/github/guibranco/GuiStracini.SDKBuilder.svg)](https://wakatime.com/badge/github/guibranco/GuiStracini.SDKBuilder)

![GuiStracini.SDKBuilder logo](https://raw.githubusercontent.com/guibranco/GuiStracini.SDKBuilder/main/logo.png)

## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LoC | 
|--------------|-------------|-------|----------|-------------|-----|
| [![Build status](https://ci.appveyor.com/api/projects/status/21n1ykfup5qpx6gy/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder/branch/main) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/GuiStracini.SDKBuilder/main)](https://github.com/guibranco/GuiStracini.SDKBuilder) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/guistracini-sdkbuilder/main?compact_message)](https://ci.appveyor.com/project/guibranco/guistracini-sdkbuilder/branch/main/tests) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=coverage&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=code_smells&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=ncloc&branch=main)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder) | 

## Code Quality

[![DeepSource](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder.svg/?label=active+issues&show_trend=true&token=SUN_b7NV-uOGUMWnxFFFUFb9)](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder/?ref=repository-badge)

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/572455795b584087bd465974d2dce1a4)](https://www.codacy.com/gh/guibranco/GuiStracini.SDKBuilder/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/GuiStracini.SDKBuilder&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/572455795b584087bd465974d2dce1a4)](https://www.codacy.com/gh/guibranco/GuiStracini.SDKBuilder/dashboard?utm_source=github.com&utm_medium=referral&utm_content=guibranco/GuiStracini.SDKBuilder&utm_campaign=Badge_Coverage)

[![codecov](https://codecov.io/gh/guibranco/GuiStracini.SDKBuilder/branch/main/graph/badge.svg?token=pFvFFTF2bb)](https://codecov.io/gh/guibranco/GuiStracini.SDKBuilder)
[![CodeFactor](https://www.codefactor.io/repository/github/guibranco/GuiStracini.SDKBuilder/badge)](https://www.codefactor.io/repository/github/guibranco/GuiStracini.SDKBuilder)

[![Maintainability](https://api.codeclimate.com/v1/badges/d7b77d89ee8537b8780a/maintainability)](https://codeclimate.com/github/guibranco/GuiStracini.SDKBuilder/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/d7b77d89ee8537b8780a/test_coverage)](https://codeclimate.com/github/guibranco/GuiStracini.SDKBuilder/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_GuiStracini.SDKBuilder&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_GuiStracini.SDKBuilder)

[![DeepSource](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder.svg/?label=active+issues&show_trend=true&token=SUN_b7NV-uOGUMWnxFFFUFb9)](https://app.deepsource.com/gh/guibranco/GuiStracini.SDKBuilder/?ref=repository-badge)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/GuiStracini.SDKBuilder.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/GuiStracini.SDKBuilder/total.svg?style=flat)](https://github.com/guibranco/GuiStracini.SDKBuilder)

Download the latest zip file from the [Release](https://github.com/GuiBranco/GuiStracini.SDKBuilder/releases) page.

### Nuget package manager

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **GuiStracini.SDKBuilder** | [![GuiStracini.SDKBuilder NuGet Version](https://img.shields.io/nuget/v/GuiStracini.SDKBuilder.svg?style=flat)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/) | [![GuiStracini.SDKBuilder NuGet Downloads](https://img.shields.io/nuget/dt/GuiStracini.SDKBuilder.svg?style=flat)](https://www.nuget.org/packages/GuiStracini.SDKBuilder/) |

---

This package allows the easy creation of an SDK (Sofware Development Kit) for consuming a REST API based on WebAPI2 conventions.
The ServiceFactory class implements the IServiceFactory interface, having the methods Get, Post, Put, Delete, Head, and Upload. It uses self-convention and custom attributes to generate smart endpoints and perform requests.

---

## Creating a new SDK

To create a new SDK, you must first acquire the API endpoints, the object (in-out) properties, and the authorization flow.

**Currently, this package only supports basic authorization** (via HTTP headers or JWT-like). OAuth/OAuth2 is not supported by default but can be implemented by yourself or in a future version. Let me know—via PR—if you make some progress on that!).
