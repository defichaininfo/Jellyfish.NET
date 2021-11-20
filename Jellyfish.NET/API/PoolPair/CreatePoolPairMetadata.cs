namespace Jellyfish.API.PoolPair;

public class CreatePoolPairMetadata
{
    public string TokenA { get; init; } = string.Empty;
    public string TokenB { get; init; } = string.Empty;
    public double Commission { get; init; }
    public bool Status { get; init; }
    public string OwnerAddress { get; init; } = string.Empty;
    public string[]? CustomRewards { get; init; }
    public string? PairSymbol { get; init; }
}
