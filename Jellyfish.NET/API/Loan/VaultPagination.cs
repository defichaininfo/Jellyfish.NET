using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class VaultPagination
{
    public string? Start { get; init; }
    [JsonProperty("including_start")]
    public bool? IncludingStart { get; init; }
    public int? Limit { get; init; } = 100;
}
