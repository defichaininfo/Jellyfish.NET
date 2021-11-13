using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class CreateAnchorInput
{
    /// <summary>
    /// The transaction id of the bitcoin UTXO to spend
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// The output index to spend in UTXO for tx fee
    /// </summary>
    public uint Vout { get; init; }

    /// <summary>
    /// Amount of output in satoshis (base unit)
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// WIF private key of bitcoin of signing this output
    /// </summary>
    [JsonProperty("privkey")]
    public string PrivateKey { get; init; } = string.Empty;
}
