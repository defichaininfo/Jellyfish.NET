using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class Block<T>
{
    public BlockHeader Header { get; init; }

    [JsonProperty("size")]
    public long BlockSize { get; init; }
    public long StrippedSize { get; init; }
    public int Weight { get; init; }
    public string MasterNode { get; init; } = string.Empty;
    public string Minter { get; init; } = string.Empty;
    public int MintedBlocks { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 StakeModifier { get; init; } = uint256.Zero;

    [JsonProperty("tx")]
    public T[] Transactions { get; init; } = Array.Empty<T>();    

    public Block(string hash, int confirmations, int height, int version, string versionHex, string merkleRoot, uint time, uint mediantime, string bits, double difficulty, string chainWork, int nTx, string previousBlockHash, string nextBlockHash)
    {
        Header = new BlockHeader
        {
            ChainWork = uint256.Parse(chainWork),
            Confirmations = confirmations,
            Hash = uint256.Parse(hash),
            Height = height,
            MedianTime = Utils.UnixTimeToDateTime(mediantime),
            MerkleRootHash = uint256.Parse(merkleRoot),
            Version = version,
            VersionHex = versionHex,
            Bits = bits,
            Difficulty = difficulty,
            TransactionCount = nTx,
            BlockTime = Utils.UnixTimeToDateTime(time),
            PreviousBlockHash = uint256.Parse(previousBlockHash),
            NextBlockHash = uint256.Parse(nextBlockHash)
        };
    }
}
