﻿namespace GuiStracini.SDKBuilder.Routing;

using System;

/// <summary>
/// Class EndpointRouteAttribute.
/// </summary>
/// <seealso cref="System.Attribute" />
[AttributeUsage(AttributeTargets.Class)]
public class EndpointRouteAttribute : Attribute
{
    #region ~Ctor

    /// <summary>
    /// Initializes a new instance of the <see cref="EndpointRouteAttribute"/> class.
    /// </summary>
    /// <param name="endPoint">The end point path of the request.</param>
    public EndpointRouteAttribute(string endPoint)
    {
        EndPoint = endPoint;
    }

    #endregion

    #region Public properties

    /// <summary>
    /// Gets the end point.
    /// </summary>
    /// <value>The end point path.</value>
    public string EndPoint { get; }

    #endregion
}
