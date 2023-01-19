// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="DefaultRouteValueAttribute.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder.Routing
{
    using System;

    /// <summary>
    /// The request parameter default value attribute.
    /// This attribute is used when a parameter value is not supplied in the object, instead the default value is used to build de endpoint.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultRouteValueAttribute : Attribute
    {
        #region ~Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultRouteValueAttribute" /> class.
        /// </summary>
        /// <param name="defaultValue">The default value.</param>
        public DefaultRouteValueAttribute(string defaultValue)
        {
            DefaultValue = defaultValue;
        }

        #endregion

        #region Public properties

        /// <summary>
        /// Gets the default value.
        /// </summary>
        /// <value>The default value.</value>
        public string DefaultValue { get; }

        #endregion
    }
}
