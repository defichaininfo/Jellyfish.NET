namespace Jellyfish.API.Account;

public class FutureSwap
{
    /// <summary>
    /// Address to fund contract and receive resulting token
    /// </summary>
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// to send in amount@token format
    /// </summary>
    public string Amount { get; init; } = string.Empty;

    /// <summary>
    /// Expected dToken if DUSD supplied
    /// </summary>
    public string? Destination { get; init; } = string.Empty;
}
