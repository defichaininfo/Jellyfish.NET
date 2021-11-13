using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class SignRawTxWithKeyErrors
{
    /// <summary>
    /// The hash of the referenced, previous transaction
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// The index of the output to spent and used as input
    /// </summary>
    public int Vout { get; init; }

    /// <summary>
    /// The hex-encoded signature script
    /// </summary>
    [JsonProperty("scriptSig")]
    public string SignatureScript { get; init; } = string.Empty;

    /// <summary>
    /// Script sequence number
    /// </summary>
    public int Sequence { get; init; }

    /// <summary>
    /// Verification or signing error related to the input
    /// </summary>
    public string Error { get; init; } = string.Empty;
}
