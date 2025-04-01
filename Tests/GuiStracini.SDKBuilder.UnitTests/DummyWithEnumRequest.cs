namespace GuiStracini.SDKBuilder.UnitTests;

using Routing;

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
