using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Oracle;

public class OracleData
{
    [JsonProperty("oracleId")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Id { get; init; } = uint256.Zero;
    public string Address { get; init; } = string.Empty;
    public OraclePriceFeed[] PriceFeeds {  get; init; } = Array.Empty<OraclePriceFeed>();
    public OracleTokenPrice[] TokenPrices { get; init; } = Array.Empty<OracleTokenPrice>();
    public double Weightage { get; init; }
}
