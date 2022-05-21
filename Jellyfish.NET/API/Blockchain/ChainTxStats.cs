using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class ChainTxStats
{
    public decimal Time { get; init; }
    public decimal TxCount { get; init; }
    [JsonProperty("window_final_block_hash")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 WindowFinalBlockHash { get; init; } = uint256.Zero;
    [JsonProperty("window_final_block_height")]
    public int WindowFinalBlockHeight { get; init; }
    [JsonProperty("window_block_count")]
    public decimal WindowBlockCount { get; init; }
    [JsonProperty("window_tx_count")]
    public decimal WindowTxCount { get; init; }
    [JsonProperty("window_interval")]
    public decimal WindowInterval { get; init; }
    public decimal TxRate { get; init; }
}
