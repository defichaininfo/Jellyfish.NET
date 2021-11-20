namespace Jellyfish.API.PoolPair;

public class PoolSwapMetadata
{
    /// <summary>
    /// address of the owner of tokenFrom
    /// </summary>
    public string From { get; init; } = string.Empty;

    /// <summary>
    /// swap from token {symbol/id}
    /// </summary>
    public string TokenFrom { get; init; } = string.Empty;

    /// <summary>
    /// amount from tokenA
    /// </summary>
    public double AmountFrom { get; init; }

    /// <summary>
    /// address of the owner of tokenTo
    /// </summary>
    public string To { get; init; } = string.Empty;

    /// <summary>
    /// swap to token {symbol/id}
    /// </summary>
    public string TokenTo { get; init; } = string.Empty;

    /// <summary>
    /// acceptable max price
    /// </summary>
    public double? MaxPrice { get; init; }
}
