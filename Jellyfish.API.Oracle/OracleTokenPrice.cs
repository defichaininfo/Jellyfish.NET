using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Oracle;

public class OracleTokenPrice
{
    public string Token { get; init; } = string.Empty;
    public string Currency { get; init; } = string.Empty;
    /// <summary>
    /// example: 0.5
    /// </summary>
    public decimal Amount { get; init; }
    /// <summary>
    /// example: 1623161076 is an Epoch time which every digit represents a second.
    /// </summary>
    [JsonProperty("timestamp")]
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }
}
