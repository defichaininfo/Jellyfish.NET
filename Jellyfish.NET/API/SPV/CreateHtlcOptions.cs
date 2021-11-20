namespace Jellyfish.API.SPV;

public class CreateHtlcOptions
{
    /// <summary>
    /// Timeout of the contract (denominated in blocks) relative to its placement in the blockchain. Minimum 9. See HTLC_MINIMUM_BLOCK_COUNT
    /// </summary>
    public string Timeout { get; init; } = string.Empty;

    /// <summary>
    /// SHA256 hash of the seed. If none provided one will be generated
    /// </summary>
    public string? SeedHash { get; init; }
}
