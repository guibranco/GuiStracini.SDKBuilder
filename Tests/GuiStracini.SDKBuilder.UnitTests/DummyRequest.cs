namespace GuiStracini.SDKBuilder.UnitTests;

using Routing;

[EndpointRoute("something/{Dummy}")]
public class DummyRequest : IBaseRequest
{
    public string Dummy { get; set; }
}
