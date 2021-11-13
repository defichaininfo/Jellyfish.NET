using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX listOrder options
/// </summary>
public class ICXListOrderOptions
{
    /// <summary>
    /// Token asset
    /// </summary>
    public string? Token { get; init; }
    /// <summary>
    /// Chain asset
    /// </summary>
    public string? Chain { get; init; }
    /// <summary>
    /// Order txid to list all offers for this order
    /// </summary>
    [JsonProperty("orderTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256? OrderTransaction {  get; init; }

    /// <summary>
    /// Maximum number of orders to return (default: 50)
    /// </summary>
    public int Limit { get; init; } = 50;

    /// <summary>
    /// Display closed orders (default: false)
    /// </summary>
    [JsonProperty("closed")]
    public bool IsClosed {  get; init; }
}
