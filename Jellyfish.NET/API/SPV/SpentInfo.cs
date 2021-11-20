using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class SpentInfo
{
    /// <summary>
    /// The transaction id
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// Number of spent confirmations
    /// </summary>
    [JsonProperty("confirms")]
    public int Confirmations { get; init; }
}
