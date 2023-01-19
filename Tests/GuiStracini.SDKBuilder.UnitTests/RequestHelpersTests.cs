// ***********************************************************************
// Assembly         : GuiStracini.SDKBuilder.UnitTests
// Author           : Guilherme Branco Stracini
// Created          : 14/01/2023
//
// Last Modified By : Guilherme Branco Stracini
// Last Modified On : 15/01/2023
// ***********************************************************************
// <copyright file="RequestHelpersTests.cs" company="GuiStracini.SDKBuilder.UnitTests">
//     Copyright (c) Guilherme Branco Stracini ME. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace GuiStracini.SDKBuilder.UnitTests
{
    using Routing;
    using Xunit;

    /// <summary>
    /// The request helpers test class
    /// </summary>
    public class RequestHelpersTests
    {
        /// <summary>
        /// Validates the request endpoint.
        /// </summary>
        [Fact]
        public void RequestEndpoint()
        {
            const string expected = "something/my-string";
            var dummy = new DummyRequest { Dummy = "my-string" };
            var actual = dummy.GetRequestEndPoint();
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Validates the request endpoint with null values.
        /// </summary>
        [Fact]
        public void RequestEndpointWithNullValues()
        {
            const string expected = "something";
            var dummy = new DummyRequest();
            var actual = dummy.GetRequestEndPoint();
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Requests the parameter default value.
        /// </summary>
        [Fact]
        public void RequestParameterDefaultValue()
        {
            const string expected = "something/?f=1&s=100&third=fourth";
            var dummy = new DummyWithEnumRequest
            {
                EnumerationKey = MyEnumeration.RD,
                EnumValue = "fourth"
            };
            var actual = dummy.GetRequestEndPoint();
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Defines the test method RequestParametersDefaultValueOverride.
        /// </summary>
        [Fact]
        public void RequestParametersDefaultValueOverride()
        {
            const string expected = "something/?f=2000&s=1000&third=fourth";
            var dummy = new DummyWithEnumRequest
            {
                EnumerationKey = MyEnumeration.RD,
                EnumValue = "fourth",
                FirstNumber = 2000,
                SecondNumber = 1000
            };
            var actual = dummy.GetRequestEndPoint();
            Assert.Equal(expected, actual);
        }
    }

    /// <summary>
    /// Class DummyRequest.
    /// Implements the <see cref="GuiStracini.SDKBuilder.BaseRequest" />
    /// </summary>
    /// <seealso cref="GuiStracini.SDKBuilder.BaseRequest" />
    [EndpointRoute("something/{Dummy}")]
    public class DummyRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the dummy.
        /// </summary>
        /// <value>The dummy.</value>
        public string Dummy { get; set; }
    }

    /// <summary>
    /// Class DummyWithEnumRequest.
    /// Implements the <see cref="GuiStracini.SDKBuilder.BaseRequest" />
    /// </summary>
    /// <seealso cref="GuiStracini.SDKBuilder.BaseRequest" />
    [EndpointRoute("something/?f={FirstNumber}&s={SecondNumber}&{EnumerationKey}={EnumValue}")]
    public class DummyWithEnumRequest : BaseRequest
    {
        /// <summary>
        /// Gets or sets the first number.
        /// </summary>
        /// <value>The first number.</value>
        [DefaultRouteValue("1")]
        public int FirstNumber { get; set; }

        /// <summary>
        /// Gets or sets the second number.
        /// </summary>
        /// <value>The second number.</value>
        [DefaultRouteValue("100")]
        public int SecondNumber { get; set; }

        /// <summary>
        /// Gets or sets the enumeration key.
        /// </summary>
        /// <value>The enumeration key.</value>
        public MyEnumeration EnumerationKey { get; set; }

        /// <summary>
        /// Gets or sets the enum value.
        /// </summary>
        /// <value>The enum value.</value>
        public string EnumValue { get; set; }
    }

    /// <summary>
    /// Enum MyEnumeration
    /// </summary>
    public enum MyEnumeration
    {
        /// <summary>
        /// The st
        /// </summary>
        [EnumRouteValue("first")]
        ST = 1,

        /// <summary>
        /// The nd
        /// </summary>
        [EnumRouteValue("second")]
        ND = 2,

        /// <summary>
        /// The rd
        /// </summary>
        [EnumRouteValue("third")]
        RD = 3
    }
}
