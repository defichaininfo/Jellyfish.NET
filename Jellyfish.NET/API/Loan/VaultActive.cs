namespace Jellyfish.API.Loan;

public class VaultActive : Vault
{
    public string[] CollateralAmounts { get; init; } = Array.Empty<string>();
    public string[] LoanAmounts { get; init; } = Array.Empty<string>();
    public string[] InterestAmounts { get; init; } = Array.Empty<string>();
    public decimal CollateralValue { get; init; }
    public decimal LoanValue { get; init; }
    public decimal InterestValue { get; init; }
    public double CollateralRatio { get; init; }
    public decimal InformativeRatio { get; init; }
}
