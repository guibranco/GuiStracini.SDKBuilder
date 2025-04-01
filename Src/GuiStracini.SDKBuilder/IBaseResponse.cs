namespace GuiStracini.SDKBuilder;

/// <summary>
/// Interface IBaseResponse
/// </summary>
public interface IBaseResponse
{
    /// <summary>
    /// Gets or sets the error code.
    /// </summary>
    /// <value>The error code.</value>
    int ErrorCode { get; set; }

    /// <summary>
    /// Gets or sets the error message.
    /// </summary>
    /// <value>The error message.</value>
    string ErrorMessage { get; set; }
}
