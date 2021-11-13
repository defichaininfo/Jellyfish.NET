using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class Transaction
{
    [JsonProperty("txid")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 TransactionId { get; init; } = uint256.Zero;
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;
    public uint Version { get; init; }
    public int Size { get; init; }
    [JsonProperty("vsize")]
    public int VirtualSize { get; init; }
    public int Weight { get; init; }
    public int LockTime { get; init; }
    [JsonProperty("vin")]
    public Vin[] Inputs { get; init; } = Array.Empty<Vin>();
    [JsonProperty("vout")]
    public Vout[] Outputs {  get; init; } = Array.Empty<Vout>();
    public string Hex { get; init; } = string.Empty;
}
