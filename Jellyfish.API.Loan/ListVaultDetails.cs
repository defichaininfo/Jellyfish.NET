namespace Jellyfish.API.Loan;

public class ListVaultDetails
{
    public string VaultId { get; init; } = string.Empty;
    public string LoanSchemeId { get; init; } = string.Empty;
    public string OwnerAddress { get; init; } = string.Empty;
    public bool IsUnderLoquidation { get; init; }
}
