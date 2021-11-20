using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListAnchorRewardConfirmationsResult
{
    /// <summary>
    /// BTC transaction height
    /// </summary>
    [JsonProperty("btxTxHeight")]
    public int BtcTransactionHeight { get; init; }

    /// <summary>
    /// BTC transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("btcTxHash")]
    public uint256 BtcTransactionHash { get; init; } = uint256.Zero;

    /// <summary>
    /// anchor height
    /// </summary>
    public int AnchorHeight { get; init; }

    /// <summary>
    /// DeFi block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DfiBlockHash { get; init; } = uint256.Zero;

    /// <summary>
    /// Previous anchor height
    /// </summary>
    [JsonProperty("prevAnchorHeight")]
    public int PreviousAnchorHeight { get; init; }

    /// <summary>
    /// the reward address
    /// </summary>
    public string RewardAddress { get; init; } = string.Empty;

    /// <summary>
    /// the confirm sign hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 ConfirmSignHash { get;init; } = uint256.Zero;

    /// <summary>
    /// number of signers
    /// </summary>
    public int Signers { get; init; }
}
