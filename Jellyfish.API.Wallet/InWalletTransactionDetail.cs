namespace Jellyfish.API.Wallet;

public class InWalletTransactionDetail
{
    public string Address { get; init; } = string.Empty;
    public InWalletTransactionCategory Category {  get; init; }
    public decimal Amount { get; init; }
    public string Label { get; init; } = string.Empty;
    public double Vout { get; init; }
    public double Fee { get; init; }
    public bool Abandoned { get; init; }
}
