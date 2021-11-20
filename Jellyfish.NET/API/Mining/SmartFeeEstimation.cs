namespace Jellyfish.API.Mining;

public class SmartFeeEstimation
{
    public double? FeeRate { get; init; }
    public string[]? Errors { get; init; }
    public int Blocks { get; init; }
}
