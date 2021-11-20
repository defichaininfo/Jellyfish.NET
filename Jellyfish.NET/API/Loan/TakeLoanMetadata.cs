namespace Jellyfish.API.Loan;

public class TakeLoanMetadata
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
    /// Address to receive tokens
    /// </summary>
    public string? To { get; init; } = string.Empty;
}
