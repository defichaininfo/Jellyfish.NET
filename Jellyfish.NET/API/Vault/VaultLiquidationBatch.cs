namespace Jellyfish.API.Vault;

public class VaultLiquidationBatch
{
    public double Index { get; init; }
    public string[] Collaterals { get; init; } = Array.Empty<string>();
    public string Loan { get; init; } = string.Empty;
    public HighestBid? HighestBid { get; init; }
}
