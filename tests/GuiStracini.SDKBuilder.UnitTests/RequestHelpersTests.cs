using Xunit;
namespace GuiStracini.SDKBuilder.UnitTests;
public class RequestHelpersTests
{
    [Fact]
    public void GetAdditionalParameter_ShouldAppendCorrectly()
    {
        string baseUrl = "someAddress?queryStringDefault=default";
        string param1 = "optional=1";
        string param2 = "optional2=2";
        string param3 = "";
        
        string result = RequestHelpers.GetAdditionalParameter(baseUrl, param1);
        Assert.Equal("someAddress?queryStringDefault=default&optional=1", result);

        result = RequestHelpers.GetAdditionalParameter(result, param2);
        Assert.Equal("someAddress?queryStringDefault=default&optional=1&optional2=2", result);

        result = RequestHelpers.GetAdditionalParameter(result, param3);
        Assert.Equal("someAddress?queryStringDefault=default&optional=1&optional2=2", result);
    }
}