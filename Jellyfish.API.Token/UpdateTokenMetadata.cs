using Newtonsoft.Json;

namespace Jellyfish.API.Token;

public class UpdateTokenMetadata
{
    public string? Symbol { get; init; }
    public string? Name { get; init; }
    public bool? IsDAT { get; init; }
    [JsonProperty("mintable")]
    public bool? IsMintable { get; init; }
    [JsonProperty("tradeable")]
    public bool? IsTradeable { get; init; }
    public bool? Finalize { get; init; }
}
