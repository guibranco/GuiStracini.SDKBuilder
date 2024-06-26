// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="RequestHelpers.cs" company="Guilherme Branco Stracini">
//     © 2019 - 2023 Guilherme Branco Stracini. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using GoodPractices;
    using Newtonsoft.Json;
    using Routing;

    /// <summary>
    /// Class Extensions.
    /// </summary>
    public static class RequestHelpers
    {
        /// <summary>
        /// Gets the request end point attribute.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>EndpointRouteAttribute.</returns>
        public static EndpointRouteAttribute GetRequestEndPointAttribute(this BaseRequest request)
        {
            if (
                request.GetType().GetCustomAttributes(typeof(EndpointRouteAttribute), false)
                    is not EndpointRouteAttribute[] endpoints
                || !endpoints.Any()
            )
            {
                return null;
            }

            return endpoints.Single();
        }

        /// <summary>
        /// Gets the request end point.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>String.</returns>
        /// <exception cref="GuiStracini.SDKBuilder.GoodPractices.RequestEndpointBadFormatException"></exception>
        /// <exception cref="GuiStracini.SDKBuilder.GoodPractices.InvalidRequestEndpointException"></exception>
        public static string GetRequestEndPoint(this BaseRequest request)
        {
            var type = request.GetType();
            var endpointAttribute = request.GetRequestEndPointAttribute();
            if (endpointAttribute == null)
            {
                return type.Name.ToUpper();
            }

            var originalEndpoint = endpointAttribute.EndPoint;
            var endpoint = originalEndpoint;
            var regex = new Regex(@"/?(?<pattern>{(?<propertyName>\w+?)})/?");
            if (!regex.IsMatch(endpoint))
            {
                return endpoint;
            }

            var used = 0;
            var skiped = 0;
            var counter = 0;
            foreach (Match match in regex.Matches(endpoint))
            {
                counter++;
                var propertyName = match.Groups["propertyName"].Value;
                var property = type.GetProperty(propertyName);
                if (property == null)
                {
                    throw new RequestEndpointBadFormatException(originalEndpoint);
                }

                var propertyType = property.PropertyType;
                var propertyValue = property.GetValue(request, null);
                if (
                    propertyValue == null
                    || (propertyType == typeof(int) && Convert.ToInt32(propertyValue) == 0)
                    || (propertyType == typeof(long) && Convert.ToInt64(propertyValue) == 0)
                    || (
                        propertyType == typeof(decimal)
                        && Convert.ToDecimal(propertyValue) == new decimal(0)
                    )
                    || (
                        propertyType == typeof(string)
                        && string.IsNullOrEmpty(propertyValue.ToString())
                    )
                )
                {
                    var defaultValue = string.Empty;
                    if (
                        property.GetCustomAttributes(typeof(DefaultRouteValueAttribute), false)
                            is DefaultRouteValueAttribute[] defaultsValues
                        && defaultsValues.Any()
                    )
                    {
                        defaultValue = defaultsValues.Single().DefaultValue;
                    }

                    endpoint = endpoint.Replace(match.Value, defaultValue);
                    if (skiped == 0 && defaultValue == string.Empty)
                    {
                        skiped = counter;
                    }

                    continue;
                }
                used = counter;
                var value = propertyValue.ToString();
                if (property.PropertyType.IsEnum)
                {
                    var field = property.PropertyType.GetField(value);
                    if (
                        field.GetCustomAttributes(typeof(EnumRouteValueAttribute), false)
                            is EnumRouteValueAttribute[] enumRouteValue
                        && enumRouteValue.Any()
                    )
                    {
                        value = enumRouteValue.Single().RouteValue;
                    }
                    else
                    {
                        value = value.ToLower();
                    }
                }

                endpoint = endpoint.Replace(match.Groups["pattern"].Value, value);
            }
            if (skiped != 0 && skiped < used)
            {
                throw new InvalidRequestEndpointException(originalEndpoint, endpoint);
            }

            return endpoint.Trim('/');
        }

        /// <summary>
        /// Gets the request additional parameter.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="requestMethod">The request method.</param>
        /// <returns>String.</returns>
        public static string GetRequestAdditionalParameter(
            this BaseRequest request,
            ActionMethod requestMethod
        )
        {
            var type = request.GetType();
            var properties = type.GetProperties()
                .Where(prop => prop.IsDefined(typeof(AdditionalRouteValueAttribute), false))
                .ToList();
            if (!properties.Any())
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            foreach (var property in properties)
            {
                if (
                    !(
                        property.GetCustomAttributes(typeof(AdditionalRouteValueAttribute), false)
                        is AdditionalRouteValueAttribute[] attributes
                    ) || attributes.All(a => a.Type != requestMethod)
                )
                {
                    continue;
                }

                var addAsQueryString = attributes
                    .Single(a => a.Type == requestMethod)
                    .AsQueryString;
                var propertyValue = property.GetValue(request);
                if (propertyValue == null)
                {
                    continue;
                }

                if (property.PropertyType == typeof(bool))
                {
                    propertyValue = propertyValue.ToString().ToLower();
                }

                var propertyName = property.Name;
                if (
                    property.GetCustomAttributes(typeof(JsonPropertyAttribute), false)
                        is JsonPropertyAttribute[] attributesJson
                    && attributesJson.Any()
                )
                {
                    propertyName = attributesJson.Single().PropertyName;
                }

                if (
                    property.PropertyType == typeof(string)
                    || property.PropertyType == typeof(bool)
                    || (property.PropertyType == typeof(int) && Convert.ToInt32(propertyValue) > 0)
                    || (property.PropertyType == typeof(long) && Convert.ToInt64(propertyValue) > 0)
                )
                {
                    builder
                        .Append("/")
                        .AppendFormat("{0}", addAsQueryString ? $"?{propertyName}=" : string.Empty)
                        .Append(propertyValue);
                }
            }
            return builder.ToString();
        }
    }
}
