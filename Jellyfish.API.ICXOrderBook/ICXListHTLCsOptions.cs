using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX listHTLC options
/// </summary>
public class ICXListHTLCsOptions
{
    /// <summary>
    /// Offer txid  for which to list all HTLCS
    /// </summary>
    [JsonProperty("offerTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 OfferTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// Maximum number of orders to return (default: 20)
    /// </summary>
    public int Limit { get; init; } = 20;

    /// <summary>
    /// Display also claimed, expired and refunded HTLCs (default: false)
    /// </summary>
    [JsonProperty("closed")]
    public bool IsClosed { get; init; }

    public ICXListHTLCsOptions(uint256 offerTransaction, int limit = 20, bool isClosed = false)
    {
        OfferTransaction = offerTransaction;
        Limit = limit;
        IsClosed = isClosed;
    }
}
