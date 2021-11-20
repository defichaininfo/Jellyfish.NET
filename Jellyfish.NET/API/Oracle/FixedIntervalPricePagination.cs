namespace Jellyfish.API.Oracle;

public class FixedIntervalPricePagination
{
    public string? Start { get; init; } = string.Empty;

    /// <summary>
    /// Maximum number of orders to return.
    /// </summary>
    public int? Limit { get; init; } = 100;
}
