namespace Jellyfish.API.Loan;

public class ListLoanTokenResult
{
    public LoanTokenDetails Token { get; init; } = new LoanTokenDetails();
    public string FixedIntervalPriceId { get; init; } = string.Empty;
    public decimal Interest { get; init; }
}
