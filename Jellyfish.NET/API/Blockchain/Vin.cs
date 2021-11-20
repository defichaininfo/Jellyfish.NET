using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class Vin
{
    public string? Coinbase { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Txid { get; init; } = uint256.Zero;
    public uint Vout { get; init; }
    [JsonProperty("scriptSig")]
    public ScriptSignature ScriptSignature { get; init; } = new ScriptSignature();
    public string[]? TxinWitness { get; init; }
    public string Sequence { get; init; } = string.Empty;
}
