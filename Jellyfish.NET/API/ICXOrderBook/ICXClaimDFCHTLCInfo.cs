using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

/// <summary>
/// ICX claimed DFCHTLC info
/// </summary>
public class ICXClaimDFCHTLCInfo
{
    /// <summary>
    /// HTLC type
    /// </summary>
    public ICXHTLCType Type { get; init; }

    /// <summary>
    /// HTLC Transaction Id
    /// </summary>
    [JsonProperty("dfchtlcTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DfcHtlcTransaction { get; init; } = uint256.Zero;

    /// <summary>
    /// HTLC claim secret
    /// </summary>
    public string Seed { get; init; } = string.Empty;

    /// <summary>
    /// HTLC creation height
    /// </summary>
    public long Height { get; init; }
}
