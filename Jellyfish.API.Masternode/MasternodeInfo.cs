using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Masternode;

public class MasternodeInfo
{
    public string OwnerAuthAddress { get; init; } = string.Empty;
    
    public string OperatorAuthAddress { get; init; } = string.Empty;
    
    public int CreationHeight { get; init; }
    
    public int ResignHeight { get; init; }

    [JsonProperty("resignTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 ResignTransaction { get; init; } = uint256.Zero;

    [JsonProperty("banTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BanTransaction { get; init; } = uint256.Zero;

    public MasternodeState State {  get; init; }

    public int MintedBlocks { get; init; }

    [JsonProperty("ownerIsMine")]
    public bool IsOwnerMine { get; init; }

    [JsonProperty("operatorIsMine")]
    public bool IsOperatorMine { get; init; }

    [JsonProperty("localMasternode")]
    public bool IsLocalMasternode { get; init; }

    public double? TargetMultiplier { get; init; }

    public double[]? TargetMultipliers { get; init; }

    public double? TimeLock { get; init; }
}
