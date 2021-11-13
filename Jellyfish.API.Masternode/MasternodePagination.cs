using Newtonsoft.Json;

namespace Jellyfish.API.Masternode;

public class MasternodePagination
{
    public string? Start { get; init; }

    /// <summary>
    /// Include starting position.
    /// </summary>
    [JsonProperty("including_start")]
    public bool? IncludingStart { get; init; } = true;

    /// <summary>
    /// Maximum number of orders to return.
    /// </summary>
    public int? Limit { get; init; } = 100;
}
