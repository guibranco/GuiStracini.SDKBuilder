// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="BaseResponse.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace GuiStracini.SDKBuilder;

/// <summary>
/// The base response class.
/// </summary>
public abstract class BaseResponse
{
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    /// <value>The error code.</value>
    public int ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    /// <value>The error message.</value>
    public string ErrorMessage { get; set; }
}
