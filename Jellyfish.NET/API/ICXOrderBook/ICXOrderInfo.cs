using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX order info
/// </summary>
public class ICXOrderInfo
{
    /// <summary>
    /// Order status
    /// </summary>
    public ICXOrderStatus Status { get; init; }

    /// <summary>
    /// Order type. DFI as [ICXOrderType.INTERNAL]
    /// </summary>
    public ICXOrderType Type {  get; init; }

    /// <summary>
    /// Symbol or id of selling token
    /// </summary>
    public string TokenFrom { get; init; } = string.Empty;

    /// <summary>
    /// Symbol or id of buying chain
    /// </summary>
    public string? ChainTo { get; init; }

    /// <summary>
    /// pubkey which can claim external HTLC in case of EXT/DFC order type
    /// </summary>
    public string? ReceivePubKey { get; init; }

    /// <summary>
    /// Symbol or id of selling chain
    /// </summary>
    public string? ChainFrom { get; init; }

    /// <summary>
    /// Symbol or id of buying token
    /// </summary>
    public string? TokenTo { get; init; }

    /// <summary>
    /// Address of DFI token for fees and selling tokens in case of DFC/BTC order type
    /// </summary>
    public string OwnerAddress { get; init; } = string.Empty;

    /// <summary>
    /// tokenFrom coins amount
    /// </summary>
    public decimal AmountFrom { get; init; }

    /// <summary>
    /// Remaining amount to fill
    /// </summary>
    public decimal AmountToFill {  get; init; }

    /// <summary>
    /// Price per unit
    /// </summary>
    public decimal OrderPrice { get; init; }

    /// <summary>
    /// 
    /// </summary>
    public decimal AmountToFillInToAsset {  get; init; }

    /// <summary>
    /// creation height
    /// </summary>
    public long Height { get; init; }

    /// <summary>
    /// Number of blocks until the order expires
    /// </summary>
    public decimal ExpireHeight {  get; init; }

    /// <summary>
    /// Close height
    /// </summary>
    public decimal? CloseHeight {  get; init; }

    /// <summary>
    /// Close order transaction Id
    /// </summary>
    [JsonProperty("closeTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 CloseTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Expired or not
    /// </summary>
    [JsonProperty("expired")]
    public bool? IsExpired { get; init; }
}
