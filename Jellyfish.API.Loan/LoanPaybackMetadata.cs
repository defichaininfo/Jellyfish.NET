namespace Jellyfish.API.Loan;

public class LoanPaybackMetadata
{
    /// <summary>
    /// Vault id
    /// </summary>
    public string VaultId { get; init; } = string.Empty;

    /// <summary>
    /// In "amount@symbol" format
    /// </summary>
    public object Amounts { get; init; } = string.Empty;

    /// <summary>
    /// Address from transfer tokens
    /// </summary>
    public string From { get; init; } = string.Empty;
}
