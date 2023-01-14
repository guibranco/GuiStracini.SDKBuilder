namespace GuiStracini.SDKBuilder;

/// <summary>
/// The base response class.
/// </summary>
public abstract class BaseResponse
{
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    /// <value>
    /// The error code.
    /// </value>
    public int ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    /// <value>
    /// The error message.
    /// </value>
    public string ErrorMessage { get; set; }
}
