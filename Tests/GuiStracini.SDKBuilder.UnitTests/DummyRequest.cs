namespace GuiStracini.SDKBuilder.UnitTests;

using Routing;

[EndpointRoute("something/{Dummy}")]
public class DummyRequest : BaseRequest
{
    public string Dummy { get; set; }
}
