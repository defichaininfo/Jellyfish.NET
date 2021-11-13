using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX RPC call Generic result
/// </summary>
public class ICXGenericResult
{
    /// <summary>
    /// Experimental warning notice
    /// </summary>
    [JsonProperty("WARNING")]
    public string Warning { get; init; } = string.Empty;

    /// <summary>
    /// Transaction id of the transaction
    /// </summary>
    [JsonProperty("txid")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 TransactionId { get; init; } = uint256.Zero;
}
