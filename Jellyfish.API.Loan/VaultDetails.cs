using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class VaultDetails
{
    public string VaultId { get; init; } = string.Empty;
    public string LoanSchemeId { get; init; } = string.Empty;
    public string OwnerAddress { get; init; } = string.Empty;
    public VaultState State { get; init; }
    public int? LiquidationHeight { get; init; }
    public double? LiquidationPenalty { get; init; }
    public int? BatchCount { get; init; }
    public AuctionBatchDetails[]? Batches { get; init; }
    public string[]? CollateralAmounts {  get; init; }
    public string[]? LoanAmounts { get; init; }
    public string[]? InterestAmounts { get; init; }
    public decimal? CollateralValue { get; init; }
    public decimal? LoanValue { get; init; }
    public decimal? InterestValue { get; init; }
    public decimal? CurrentRatio { get; init; }
}
