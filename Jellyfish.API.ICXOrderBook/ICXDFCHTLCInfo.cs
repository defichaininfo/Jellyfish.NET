using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX DFCHTLC info
/// </summary>
public class ICXDFCHTLCInfo
{
    /// <summary>
    /// HTLC type
    /// </summary>
    public ICXHTLCType Type { get; init; }

    /// <summary>
    /// Status of the HTLC
    /// </summary>
    public ICXHTLCStatus Status {  get; init; }

    /// <summary>
    /// Offer Transaction Id
    /// </summary>
    [JsonProperty("offerTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OfferTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Amount in external asset
    /// </summary>
    [JsonProperty("amountInEXTAsset")]
    public decimal AmountInExternalAsset { get; init; }

    /// <summary>
    /// Hash of DFCHTLC
    /// </summary>
    [JsonProperty("hash")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;

    /// <summary>
    /// Timeout in blocks
    /// </summary>
    public long Timeout { get; init; }

    /// <summary>
    /// HTLC creation height
    /// </summary>
    public long Height { get; init; }

    /// <summary>
    /// HTLC refund height
    /// </summary>
    public long RefundHeight { get; init; }
}
