namespace Jellyfish.API.Loan;

public class WithdrawVault
{
    /// <summary>
    /// Vault id
    /// </summary>
    public string VaultId { get; init; } = string.Empty;

    /// <summary>
    /// Collateral address
    /// </summary>
    public string To { get; init; } = string.Empty;

    /// <summary>
    /// In "amount@symbol" format
    /// </summary>
    public string Amount { get; init; } = string.Empty;

}
