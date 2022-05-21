namespace Jellyfish.API.Vault;

public class HighestBid
{
    /// <summary>
    /// amount@symbol
    /// </summary>
    public string Amount { get; init; } = string.Empty;
    public string Owner { get; init; } = string.Empty;
}
