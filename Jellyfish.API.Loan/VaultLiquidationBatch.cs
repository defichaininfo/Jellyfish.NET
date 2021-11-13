namespace Jellyfish.API.Loan;

public class VaultLiquidationBatch
{
    public decimal Index { get; init; }
    public string[] Collaterals { get; init; } = Array.Empty<string>();
    public string Loan { get; init; } = string.Empty;
}
