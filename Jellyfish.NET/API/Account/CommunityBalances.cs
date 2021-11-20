namespace Jellyfish.API.Account;

public class CommunityBalances
{
    public decimal AnchorReward { get; init; }
    public decimal? IncentiveFunding { get; init; }
    public decimal Burnt { get; init; }
    public decimal? Swap { get; init; }
    public decimal? Futures { get; init; }
    public decimal? Options { get; init; }
    public decimal? Unallocated { get; init; }
    public decimal? Unknown { get; init; }
}
