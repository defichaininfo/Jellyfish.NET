namespace Jellyfish.API.Loan;

public class VaultLiquidation : Vault
{
    public int LiquidationHeight { get; init; }
    public double LiquidationPenalty { get; init; }
    public int BatchCount { get; init; }
    public VaultLiquidationBatch[] Batches { get; init; } = Array.Empty<VaultLiquidationBatch>();
}
