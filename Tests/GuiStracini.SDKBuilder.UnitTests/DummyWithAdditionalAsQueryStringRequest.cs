namespace GuiStracini.SDKBuilder.UnitTests;

using Routing;

[EndpointRoute("something")]
public class DummyWithAdditionalAsQueryStringRequest : BaseRequest
{
    [AdditionalRouteValue(ActionMethod.GET, true)]
    public string Test { get; set; }

    [AdditionalRouteValue(ActionMethod.POST, true)]
    public string Test2 { get; set; }
}
