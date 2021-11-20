using Jellyfish.API.Token;

namespace Jellyfish.API.Loan;

public class LoanTokenResult
{
    public TokenResult Token { get; init; } = new TokenResult();
    public string FixedIntervalPriceId { get; init; } = string.Empty;
    public decimal Interest { get; init; }
}
