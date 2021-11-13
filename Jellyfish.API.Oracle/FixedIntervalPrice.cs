namespace Jellyfish.API.Oracle;

public class FixedIntervalPrice
{
    public int ActivePriceBlock { get; init; }
    public int NextPriceBlock { get; init; }
    public string FixedIntervalPriceId { get; init; } = string.Empty;
    public decimal ActivePrice { get; init; }
    public decimal NextPrice { get; init; }
    public double Timestamp { get; init; }
    public bool IsLive { get; init; }
}
