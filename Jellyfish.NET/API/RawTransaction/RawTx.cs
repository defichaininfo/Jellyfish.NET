using Jellyfish.API.Blockchain;
using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class RawTx
{
    /// <summary>
    /// Specified the block whether is in active chain
    /// </summary>
    [JsonProperty("in_active_chain")]
    public bool? IsInActiveChain { get; init; }

    /// <summary>
    /// The transaction id
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// The transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;

    /// <summary>
    /// The version
    /// </summary>
    public double Version { get; init; }

    /// <summary>
    /// The serialized transaction size
    /// </summary>
    public double Size { get; init; }

    /// <summary>
    /// The virtual transaction size
    /// </summary>
    public double VSize { get; init; }

    /// <summary>
    /// The transaction's weight (between vsize*4-3 and vsize*3)
    /// </summary>
    public double Weight { get; init; }

    /// <summary>
    /// The lock time
    /// </summary>
    public int LockTime { get; init; }

    /// <summary>
    /// Vector input
    /// </summary>
    public Vin[] Vin { get; init; } = Array.Empty<Vin>();

    /// <summary>
    /// Vector output
    /// </summary>
    public Vout[] Vout { get; init; } = Array.Empty<Vout>();

    /// <summary>
    /// The serialized, hex-encoded for 'txid'
    /// </summary>
    public string Hex { get; init; } = string.Empty;

    /// <summary>
    /// the block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BlockHash { get; init; } = uint256.Zero;

    /// <summary>
    /// Number of block confirmations
    /// </summary>
    public int Confirmations { get; init; }

    /// <summary>
    /// Same as 'blocktime'
    /// </summary>
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }

    /// <summary>
    /// The block time in seconds since epoch (Jan 1 1970 GMT)
    /// </summary>
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset BlockTime { get; init; }
}
