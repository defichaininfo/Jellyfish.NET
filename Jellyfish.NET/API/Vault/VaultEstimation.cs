namespace Jellyfish.API.Vault;

public class VaultEstimation
{
    public decimal CollateralValue { get; init; } // n.nnnnnnnn (amount) The total collateral value in USD
    public decimal LoanValue { get; init; } // n.nnnnnnnn (amount) The total loan value in USD
    public decimal InformativeRatio { get; init; } // n.nnnnnnnn (amount) Informative ratio with 8 digit precision
    public decimal CollateralRatio { get; init; } // n (uint) Ratio as unsigned int
}
