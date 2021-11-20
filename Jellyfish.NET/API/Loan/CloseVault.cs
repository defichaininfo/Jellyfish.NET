namespace Jellyfish.API.Loan;

public class CloseVault
{
    /// <summary>
    /// Vault id
    /// </summary>
    public string VaultId { get; init; } = string.Empty;
    /// <summary>
    /// Valid address to receive collateral tokens
    /// </summary>
    public string To { get; init; } = string.Empty;
}
