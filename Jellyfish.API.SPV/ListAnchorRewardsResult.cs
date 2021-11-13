using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListAnchorRewardsResult
{
    /// <summary>
    /// the anchor transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("AnchorTxHash")]
    public uint256 AnchorTransactionHash { get; init; } = uint256.Zero;

    /// <summary>
    /// the reward transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("RewardTxHash")]
    public uint256 RewardTransactionHash { get; init; } = uint256.Zero;
}
