namespace Jellyfish.API.Oracle;

public class ListFixedIntervalPrice
{
    public string PriceFeedId { get; init; } = string.Empty;
    public decimal ActivePrice { get; init; }
    public decimal NextPrice { get; init; }
    public double Timestamp { get; init; }
    public bool IsLive { get; init; }
}