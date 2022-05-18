namespace Jellyfish.API.Loan;

public class Interest
{
    public string Token { get; init; } = string.Empty;
    public decimal RealizedInterestPerBlock { get; init; }
    public decimal TotalInterest {  get; init; }
    public decimal InterestPerBlock { get; init; }
}
