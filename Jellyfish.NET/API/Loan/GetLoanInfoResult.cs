namespace Jellyfish.API.Loan;

public class GetLoanInfoResult
{
    public decimal CurrentPriceBlock { get; init; }
    public decimal NextPriceBlock { get; init; }
    public LoanConfig Defaults { get; init; } = new LoanConfig();
    public LoanSummary Totals { get; init; } = new LoanSummary();
}
