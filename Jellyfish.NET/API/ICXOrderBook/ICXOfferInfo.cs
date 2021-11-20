using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX offer info
/// </summary>
public class ICXOfferInfo
{
    /// <summary>
    /// Transaction id of the order tx for which is the offer
    /// </summary>
    [JsonProperty("orderTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OrderTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Offer status
    /// </summary>
    public ICXOrderStatus Status {  get; init; }

    /// <summary>
    /// Amount fulfilling the order
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Amount fulfilling from asset
    /// </summary>
    public decimal AmountInFromAsset { get; init; }

    /// <summary>
    /// Address of DFI token and for receiving tokens in case of EXT/DFC order
    /// </summary>
    public string OwnerAddress { get; init; } = string.Empty;

    /// <summary>
    /// Pubkey which can claim external HTLC in case of EXT/DFC order type
    /// </summary>
    public string? ReceivePubKey { get; init; }

    /// <summary>
    /// Taker fee
    /// </summary>
    public decimal TakerFee { get;init; }

    /// <summary>
    /// Expire height
    /// </summary>
    public decimal ExpireHeight { get; init; }
}
