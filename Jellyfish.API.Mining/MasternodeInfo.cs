using Jellyfish.API.Masternode;
using NBitcoin;
using NBitcoin.JsonConverters;
using System.Text.Json.Serialization;

namespace Jellyfish.API.Mining;

/// <summary>
/// Masternode related information
/// </summary>
public class MasternodeInfo
{
    public string Id { get; init; } = string.Empty;
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Operator { get; init; } = uint256.Zero;
    public MasternodeState State { get; init; }
    public bool Generate { get; init; }
    public int MintedBlocks { get; init; }
    public string LastBlockCreationAttempt { get; init; } = string.Empty;
    public double TargetMultiplier { get; init; }
}
