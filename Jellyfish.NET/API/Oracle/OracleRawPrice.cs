using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Oracle;

public class OracleRawPrice
{
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OracleId { get; init; } = uint256.Zero;
    public OraclePriceFeed? PriceFeeds { get; init; }
    [JsonProperty("rawprice")]
    public decimal RawPrice { get; init; }
    public decimal Weightage { get; init; }
    public OracleRawPriceState State { get; init; }
    [JsonProperty("timestamp")]
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }
}
