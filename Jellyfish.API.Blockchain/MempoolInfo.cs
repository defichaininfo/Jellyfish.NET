using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class MempoolInfo
{
    [JsonProperty("loaded")]
    public bool IsLoaded { get; init; }
    public long Size { get; init; }
    public long Bytes { get; init; }
    public long Usage { get; init; }
    [JsonProperty("maxmempool")]
    public long MaxMempool { get; init; }
    [JsonProperty("mempoolminfee")]
    public decimal MempoolMinimumFee {  get; init; }
    [JsonProperty("minrelaytxfee")]
    public decimal MinimumRelayTransactionFee { get; init; }
}
