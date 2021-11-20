using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class BlockStats
{
    [JsonProperty("avgfee")]
    public decimal AverageFee { get; init; }
    [JsonProperty("avgfeerate")]
    public decimal AverageFeeRate { get; init; }
    [JsonProperty("avgtxsize")]
    public decimal AverageTransactionSize { get; init; }
    [JsonProperty("blockhash")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BlockHash { get; init; } = uint256.Zero;
    public int Height { get; init; }
    public int Ins { get; init; }
    [JsonProperty("maxfee")]
    public decimal MaximumFee { get; init; }
    [JsonProperty("maxfeerate")]
    public decimal MaximumFeeRate { get; init; }
    [JsonProperty("maxtxsize")]
    public decimal MaximumTransactionSize { get; init; }
    [JsonProperty("medianfee")]
    public decimal MedianFee { get; init; }
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    [JsonProperty("mediantime")]
    public DateTimeOffset MedianTime { get; init; }
    [JsonProperty("mediantxsize")]
    public decimal MedianTransactionSize { get; init; }
    [JsonProperty("minfee")]
    public decimal MinimumFee { get; init; }
    [JsonProperty("minfeerate")]
    public decimal MinimumFeeRate { get; init; }
    [JsonProperty("mintxsize")]
    public decimal MinimumTransactionSize { get; init; }
    public int Outs { get; init; }
    public decimal Subsidy { get; init; }
    [JsonProperty("swtotal_size")]
    public decimal SwTotalSize { get; init; }
    [JsonProperty("swtotal_weight")]
    public decimal SwTotalWeight { get; init; }
    [JsonProperty("swtxs")]
    public int SwTransactions { get; init; }
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }
    [JsonProperty("total_out")]
    public int TotalOut { get; init; }
    [JsonProperty("total_size")]
    public decimal TotalSize { get; init; }
    [JsonProperty("total_weight")]
    public decimal TotalWeight { get; init; }
    [JsonProperty("totalfee")]
    public decimal TotalFee { get; init; }
    [JsonProperty("txs")]
    public int Transactions { get; init; }
    [JsonProperty("utxo_increase")]
    public int UtxoIncrease { get; init; }
    [JsonProperty("utxo_size_inc")]
    public decimal UtxoSizeIncrease { get; init; }
    [JsonProperty("feerate_percentiles")]
    public decimal[] FeeRatePercentiles { get; init; } = new decimal[5];
}
