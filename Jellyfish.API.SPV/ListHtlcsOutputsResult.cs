using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListHtlcsOutputsResult
{
    /// <summary>
    /// The transaction id
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// Output relating to the HTLC address
    /// </summary>
    public uint Vout { get; init; }

    /// <summary>
    /// Total amount of BTC recieved by the address
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// HTLC address
    /// </summary>
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// Number of confirmations
    /// </summary>
    [JsonProperty("confirms")]
    public int Confirmations { get; init; }

    /// <summary>
    /// Object containing spent info
    /// </summary>
    public SpentInfo Spent { get; init; } = new SpentInfo();
}
