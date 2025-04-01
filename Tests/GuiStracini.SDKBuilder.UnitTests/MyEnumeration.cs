namespace GuiStracini.SDKBuilder.UnitTests;

using Routing;

public enum MyEnumeration
{
    [EnumRouteValue("first")]
    ST = 1,

    [EnumRouteValue("second")]
    ND = 2,

    [EnumRouteValue("third")]
    RD = 3,
}
