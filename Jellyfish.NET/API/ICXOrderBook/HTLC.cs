using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// HTLC
/// </summary>
public class HTLC
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
    /// Hash of seed used for the hash lock part
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;

    /// <summary>
    /// Timeout (absolute in blocks) for expiration of HTLC in DFI blocks
    /// </summary>
    public uint? Timeout { get; init; }
}
