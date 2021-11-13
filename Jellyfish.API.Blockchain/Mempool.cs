using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class Mempool
{
    public long VSize { get; init; }
    public long? Size { get; init; }
    public long Weight { get; init; }
    public decimal Fee { get; init; }
    public decimal ModifiedFee { get; init; }
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }
    public int Height { get; init; }
    public int DescendantCount { get; init; }
    public long DescendantSize { get; init; }
    public long DescendantFees {  get; init; }
    public int AncestorCount { get; init; }
    public long AncestorSize { get; init; }
    public long AncestorFees { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Wtxid { get; init; } = uint256.Zero;
    public Fees? Fees {  get; init; }
    public string[] Depends { get; init; } = Array.Empty<string>();
    public string[] SpentBy { get; init; } = Array.Empty<string>();
    [JsonProperty("bip125-replaceable")]
    public bool Bip125Replaceable { get; init; }
}
