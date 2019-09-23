// ***********************************************************************
// Assembly         : GuiStracini.Mandae
// Author           : Guilherme Branco Stracini
// Created          : 10/01/2018
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 10/01/2018
// ***********************************************************************
// <copyright file="BaseResponse" company="Guilherme Branco Stracini">
//     Copyright © 2018 Guilherme Branco Stracini
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder
{
    using System;

    /// <summary>
    /// The base response class.
    /// </summary>
    public abstract class BaseResponse
    {
        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        public Int32 ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        /// <value>
        /// The error message.
        /// </value>
        public String ErrorMessage { get; set; }
    }
}
