using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// External HTLC
/// </summary>
public class ExternalHTLC
{
    /// <summary>
    /// Transaction Id of the offer transaction for which the HTLC is 
    /// </summary>
    [JsonProperty("offerTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OfferTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Amount in HTLC
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Script address of external HTLC
    /// </summary>
    public string HtlcScriptAddress { get; init; } = string.Empty;

    /// <summary>
    /// Hash of seed used for the hash lock part
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;

    /// <summary>
    /// Pubkey of the owner to which the funds are refunded if HTLC timeouts
    /// </summary>
    public string OwnerPubKey { get; init; } = string.Empty;

    /// <summary>
    /// Timeout (absolute in blocks) for expiration of HTLC in DFI blocks
    /// </summary>
    public uint Timeout { get; init; }
}
