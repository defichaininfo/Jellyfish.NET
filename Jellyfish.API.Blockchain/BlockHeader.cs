using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class BlockHeader
{
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;
    public int Confirmations { get; init; }
    public int Height { get; init; }
    public int Version { get; init; }
    public string VersionHex { get; init; } = string.Empty;

    [JsonProperty("merkleroot")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 MerkleRootHash { get; init; } = uint256.Zero;

    [JsonProperty("time")]
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset BlockTime { get; init; }

    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset MedianTime { get; init; }

    public string Bits { get; init; } = string.Empty;

    public double Difficulty { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 ChainWork { get; init; } = uint256.Zero;

    [JsonProperty("nTx")]
    public int TransactionCount { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 PreviousBlockHash { get; init; } = uint256.Zero;


    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 NextBlockHash { get; init; } = uint256.Zero;
}
