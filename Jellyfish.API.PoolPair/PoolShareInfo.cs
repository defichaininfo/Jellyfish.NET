using Newtonsoft.Json;

namespace Jellyfish.API.PoolPair;

public class PoolShareInfo
{
    public string PoolId { get; init; } = string.Empty;
    public string Owner { get; init; } = string.Empty;
    [JsonProperty("%")]
    public decimal Percent { get; init; }
    public decimal Amount { get; init; }
    public decimal TotalLiquidity { get; init; }
}
