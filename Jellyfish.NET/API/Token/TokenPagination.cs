using Newtonsoft.Json;

namespace Jellyfish.API.Token;

public class TokenPagination
{
    public int Start { get; init; }
    [JsonProperty("including_start")]
    public bool IncludingStart { get; init; } = true;
    public int Limit { get; init; } = 100;
}
