namespace Jellyfish.API.Loan;

public class AuctionDetail
{
    public string VaultId { get; init; } = string.Empty;
    public int BatchCount { get; init; }
    public double LiquidationPenalty { get; init; }
    public int LiquidationHeight { get; init; }
    public VaultLiquidationBatch[] Batches { get; init; } = Array.Empty<VaultLiquidationBatch>();
    public string LoanSchemeId { get; init; } = string.Empty;
    public string OwnerAddress { get; init; } = string.Empty;
    public string State { get; init; } = string.Empty;
}
