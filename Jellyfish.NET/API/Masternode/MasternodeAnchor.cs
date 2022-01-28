using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Masternode;

public class MasternodeAnchor
{
    public int AnchorHeight { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 AnchorHash { get; init; } = uint256.Zero;
    public string RewardAddress { get; init; } = string.Empty;
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DfiRewardHash { get; init; } = uint256.Zero;
    public int BtcAnchorHeight { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BtcAnchorHash { get; init; } = uint256.Zero;
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 ConfirmSignHash { get; init; } = uint256.Zero;
}
