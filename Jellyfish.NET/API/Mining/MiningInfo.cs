using Jellyfish.API.Blockchain;
using Newtonsoft.Json;

namespace Jellyfish.API.Mining;

/// <summary>
/// Minting related information
/// </summary>
public class MiningInfo
{
    public int Blocks { get; init; }
    public double? CurrentBlockWeight { get; init; }
    [JsonProperty("currentblocktx")]
    public int? CurrentBlockTransactions { get; init; }
    public double Difficulty { get; init; }
    public bool IsOperator { get; init; }
    public MasternodeInfo[] Masternodes { get; init; } = Array.Empty<MasternodeInfo>();
    [JsonProperty("networkhashps")]
    public double NetworkHashesPerSecond { get; init; }
    [JsonProperty("pooledtx")]
    public int PooledTransactions { get; init; }
    public ChainType Chain { get; init; }
    public string Warnings { get; init; } = string.Empty;
}
