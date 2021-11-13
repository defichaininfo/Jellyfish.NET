using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class SignRawTxWithKeyPrevTx
{
    /// <summary>
    /// The transaction id
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("txid")]
    public uint256 TransactionId { get; init; } = uint256.Zero;

    /// <summary>
    /// The output number
    /// </summary>
    public int Vout { get; init; }

    /// <summary>
    /// Pubkey
    /// </summary>
    public string ScriptPubKey { get; init; } = string.Empty;

    /// <summary>
    /// Required for P2SH or P2WSH
    /// </summary>
    public string? RedeemScript { get; init; }

    /// <summary>
    /// Required for P2WSH or P2SH-P2WSH witness script
    /// </summary>
    public string? WitnessScript { get; init; }

    /// <summary>
    /// Required for segwit inputs
    /// </summary>
    public decimal? Amount { get; init; }
}
