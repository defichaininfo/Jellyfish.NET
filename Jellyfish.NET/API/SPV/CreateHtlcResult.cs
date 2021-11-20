namespace Jellyfish.API.SPV;

public class CreateHtlcResult
{
    /// <summary>
    /// The value of the new Bitcoin address
    /// </summary>
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// Hex-encoded redemption script
    /// </summary>
    public string RedeemScript { get; init; } = string.Empty;

    /// <summary>
    /// Hex-encoded seed
    /// </summary>
    public string? Seed { get; init; }

    /// <summary>
    /// Hex-encoded seed hash
    /// </summary>
    public string? SeedHash { get; init; }
}
