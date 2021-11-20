using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class UTXODetails
{
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BestBlock { get; init; } = uint256.Zero;
    public int Confirmations { get; init; }
    public decimal Value { get; init; }
    public ScriptPubKey ScriptPubKey { get; init; } = new ScriptPubKey();
    public bool Coinbase { get; init; }
}
