namespace Jellyfish.API.SPV;

public class DecodeHtlcResult
{
    /// <summary>
    /// seller's public key
    /// </summary>
    public string SellerKey { get; init; } = string.Empty;

    /// <summary>
    /// buyer's public key
    /// </summary>
    public string BuyerKey { get; init; } = string.Empty;

    /// <summary>
    /// Timeout of the contract (denominated in blocks) relative to its placement in the blockchain at creation time
    /// </summary>
    public int Blocks { get; init; }

    /// <summary>
    /// Hex-encoded seed hash
    /// </summary>
    public string Hash { get; init; } = string.Empty;
}
