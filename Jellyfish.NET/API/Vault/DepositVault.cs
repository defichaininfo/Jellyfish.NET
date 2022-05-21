namespace Jellyfish.API.Vault;

public class DepositVault
{
    public string VaultId { get; init; } = string.Empty;
    /// <summary>
    /// Collateral address
    /// </summary>
    public string From { get; init; } = string.Empty;
    /// <summary>
    /// In "amount@symbol" format
    /// </summary>
    public string Amount { get; init; } = string.Empty;
}
