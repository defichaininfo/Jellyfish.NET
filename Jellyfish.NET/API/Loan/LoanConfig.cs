namespace Jellyfish.API.Loan;

public class LoanConfig
{
    public decimal FixedIntervalBlocks { get; init; }
    public decimal MaxPriceDeviationPct { get; init; }
    public decimal MinOraclesPerPrice { get; init; }
    public string Scheme { get; init; } = string.Empty;
}
