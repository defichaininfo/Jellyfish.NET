using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class TestMempoolAcceptResult
{
    /// <summary>
    /// The transaction hash in hex
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// If the mempool allows this tx to be inserted
    /// </summary>
    [JsonProperty("allowed")]
    public bool IsAllowed { get; init; }

    /// <summary>
    /// Rejection string, only present when 'allowed' is false
    /// </summary>
    [JsonProperty("reject-reason")]
    public string? RejectionReason { get; init; }
}
