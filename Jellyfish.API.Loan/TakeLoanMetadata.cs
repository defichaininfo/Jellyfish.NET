namespace Jellyfish.API.Loan;

public class TakeLoanMetadata
{
    public string VaultId { get; init; } = string.Empty;
    /// <summary>
    /// In "amount@symbol" format
    /// </summary>
    public string Amounts { get; init; } = string.Empty;
}
