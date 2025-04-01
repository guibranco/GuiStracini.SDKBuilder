namespace GuiStracini.SDKBuilder.UnitTests;

using Xunit;

public class RequestHelpersTests
{
    [Fact]
    public void RequestEndpoint()
    {
        const string expected = "something/my-string";
        var dummy = new DummyRequest { Dummy = "my-string" };
        var actual = dummy.GetRequestEndPoint();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RequestEndpointWithNullValues()
    {
        const string expected = "something";
        var dummy = new DummyRequest();
        var actual = dummy.GetRequestEndPoint();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RequestParameterDefaultValue()
    {
        const string expected = "something/?f=1&s=100&third=fourth";
        var dummy = new DummyWithEnumRequest
        {
            EnumerationKey = MyEnumeration.RD,
            EnumValue = "fourth",
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
            SecondNumber = 1000,
        };
        var actual = dummy.GetRequestEndPoint();
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void RequestParametersWithAdditionalAsQueryString()
    {
        const string expected = "something?Test=TestValue";
        var dummy = new DummyWithAdditionalAsQueryStringRequest { Test = "TestValue" };
        var actual = dummy.GetRequestEndPoint();
        Assert.Equal(expected, actual);
    }
}
