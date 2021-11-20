using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class BlockchainInfo
{
    public ChainType Chain { get; init; }
    public uint Blocks { get; init; }
    public uint Headers { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BestBlockHash { get; init; } = uint256.Zero;

    public double Difficulty { get; init; }

    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset MedianTime { get; init; }

    public double VerificationProgress { get; init; }

    [JsonProperty("initialblockdownload")]
    public bool IsInitialBlockDownload { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Chainwork { get; init; } = uint256.Zero;

    [JsonProperty("size_on_disk")]
    public uint SizeOnDisk { get; init; }

    [JsonProperty("pruned")]
    public bool IsPruned { get; init; }
    public List<SoftFork> SoftForks { get; init; }
    public string Warnings { get; init; } = string.Empty;

    public BlockchainInfo(Dictionary<string, SoftFork> softforks)
    {
        SoftForks = new List<SoftFork>();
        foreach (var entry in softforks)
        {
            var softFork = entry.Value;
            softFork.Id = entry.Key;
            SoftForks.Add(softFork);
        }
    }
}
