using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class CreateAnchorResult
{
    /// <summary>
    /// the transaction hex
    /// </summary>
    [JsonProperty("txHex")]
    public string TransactionHex { get; init; } = string.Empty;

    /// <summary>
    /// the transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txHash")]
    public uint256 TransactionHash { get; init; } = uint256.Zero;

    /// <summary>
    /// the defi block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DefiHash { get; init; } = uint256.Zero;

    /// <summary>
    /// the defi block height
    /// </summary>
    public int DefiHeight { get; init; }

    /// <summary>
    /// estimated anchor reward
    /// </summary>
    public decimal EstimatedReward { get; init; }

    /// <summary>
    /// created anchor cost
    /// </summary>
    public decimal Cost { get; init; }

    /// <summary>
    /// status of send result
    /// </summary>
    public double SendResult { get; init; }

    /// <summary>
    /// decoded sendResult
    /// </summary>
    public string SendMessage { get; init; } = string.Empty;
}
