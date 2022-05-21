namespace Jellyfish.API.Loan;

public class PaybackLoanMetadataV2
{
    /// <summary>
    /// Vault id
    /// </summary>
    public string VaultId { get; init; } = string.Empty;

    /// <summary>
    /// Address from transfer tokens
    /// </summary>
    public string From { get; init; } = string.Empty;

    public TokenPaybackAmount[] Loans { get; init; } = Array.Empty<TokenPaybackAmount>();
}