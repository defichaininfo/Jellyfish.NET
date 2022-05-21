using Newtonsoft.Json;

namespace Jellyfish.API.Vault;

public class AuctionPagination
{
    public AuctionPaginationStart? Start { get; init; }
    [JsonProperty("including_start")]
    public bool? IncludingStart { get; init; }
    public int? Limit { get; init; } = 100;
}
