using Newtonsoft.Json;

namespace Jellyfish.API.PoolPair;

public class PoolPairPagination
{
    public int Start { get; init; }
    [JsonProperty("including_start")]
    public bool IncludingStart { get; init; } = true;
    public int Limit { get; init; } = 100;
}
