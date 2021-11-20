using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public class AccountPagination
{
    public int? Start { get; init; }
    [JsonProperty("including_start")]
    public bool? IncludingStart { get; init; }
    public int? Limit { get; init; }
}
