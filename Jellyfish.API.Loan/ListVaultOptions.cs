namespace Jellyfish.API.Loan;

public class ListVaultOptions
{
    public string? OwnerAddress { get; init; } = string.Empty;
    public string? LoanSchemeId { get; init; } = string.Empty;
    public bool? IsUnderLiquiditation { get; init; } = false;
}
