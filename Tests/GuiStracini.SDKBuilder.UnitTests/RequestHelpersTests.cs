﻿namespace GuiStracini.SDKBuilder.UnitTests
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

    [EndpointRoute("something/{Dummy}")]
    public class DummyRequest : BaseRequest
    {
        public string Dummy { get; set; }
    }

    [EndpointRoute("something/?f={FirstNumber}&s={SecondNumber}&{EnumerationKey}={EnumValue}")]
    public class DummyWithEnumRequest : BaseRequest
    {
        [DefaultRouteValue("1")]
        public int FirstNumber { get; set; }

        [DefaultRouteValue("100")]
        public int SecondNumber { get; set; }

        public MyEnumeration EnumerationKey { get; set; }

        public string EnumValue { get; set; }
    }

    public enum MyEnumeration
    {
        [EnumRouteValue("first")]
        ST = 1,

        [EnumRouteValue("second")]
        ND = 2,

        [EnumRouteValue("third")]
        RD = 3
    }
}
