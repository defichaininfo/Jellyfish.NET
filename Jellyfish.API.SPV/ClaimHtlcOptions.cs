namespace Jellyfish.API.SPV;

public class ClaimHtlcOptions
{
    /// <summary>
    /// HTLC seed
    /// </summary>
    public string Seed { get; init; } = string.Empty;

    /// <summary>
    /// Fee rate in satoshis per KB
    /// </summary>
    public decimal? FeeRate { get; init; }
}
