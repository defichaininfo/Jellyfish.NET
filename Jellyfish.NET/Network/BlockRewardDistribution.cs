namespace Jellyfish.Network;

public class BlockRewardDistribution
{
    public decimal Masternode { get; init; }
    public decimal Community { get; init; }
    public decimal Anchor { get; init; }
    public decimal Liquidity { get; init; }
    public decimal Loan { get; init; }
    public decimal Options { get; init; }
    public decimal UnAllocated { get; init; }
}

