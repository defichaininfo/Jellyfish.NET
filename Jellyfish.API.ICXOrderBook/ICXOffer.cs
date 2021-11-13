using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX offer
/// </summary>
public class ICXOffer
{
    /// <summary>
    /// Transaction id of the order tx for which is the offer
    /// </summary>
    [JsonProperty("orderTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OrderTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Amount fulfilling the order
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Address of DFI token and for receiving tokens in case of EXT/DFC order
    /// </summary>
    public string OwnerAddress { get; init; } = string.Empty;

    /// <summary>
    /// Pubkey which can claim external HTLC in case of EXT/DFC order type
    /// </summary>
    public string? ReceivePubKey { get; init; }

    /// <summary>
    /// Number of blocks until the offer expires, default 10 DFI blocks
    /// </summary>
    public int Expiry { get; init; } = 10;
}
