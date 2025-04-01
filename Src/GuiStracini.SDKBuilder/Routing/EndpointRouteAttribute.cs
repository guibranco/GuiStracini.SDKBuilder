// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="EndpointRouteAttribute.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace GuiStracini.SDKBuilder.Routing;

using System;

/// <summary>
/// Class EndpointRouteAttribute.
/// </summary>
/// <seealso cref="System.Attribute" />
[AttributeUsage(AttributeTargets.Class)]
public class EndpointRouteAttribute : Attribute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointRouteAttribute" /> class.
    /// </summary>
    /// <param name="endPoint">The end point path of the request.</param>
    public EndpointRouteAttribute(string endPoint)
    {
        EndPoint = endPoint;
    }

    /// <summary>
    /// Gets the end point.
    /// </summary>
    /// <value>The end point path.</value>
    public string EndPoint { get; }
}
