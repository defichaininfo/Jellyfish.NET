namespace Jellyfish.API.Loan;

public class LoanSummary
{
    public decimal CollateralTokens { get; init; }
    public decimal CollateralValue { get; init; }
    public decimal LoanTokens { get; init; }
    public decimal LoanValue { get; init; }
    public decimal OpenAuctions { get; init; }
    public decimal OpenVaults { get; init; }
    public decimal Schemes { get; init; }
}
