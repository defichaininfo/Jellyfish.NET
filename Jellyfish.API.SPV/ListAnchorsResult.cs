using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListAnchorsResult
{
    /// <summary>
    /// BTC block height
    /// </summary>
    public int BtcBlockHeight { get; init; }

    /// <summary>
    /// BTC block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BtcBlockHash { get; init; } = uint256.Zero;

    /// <summary>
    /// BTC transaction hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    [JsonProperty("btcTxHash")]
    public uint256 BtcTransactionHash { get; init; } = uint256.Zero;

    /// <summary>
    /// previous anchor
    /// </summary>
    public string PreviousAnchor { get; init; } = string.Empty;

    /// <summary>
    /// defi block height
    /// </summary>
    public int DefiBlockHeight { get; init; }

    /// <summary>
    /// defi block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DefiBlockHash { get; init; } = uint256.Zero;

    /// <summary>
    /// anchor reward address
    /// </summary>
    public string RewardAddress { get; init; } = string.Empty;

    /// <summary>
    /// BTC confirmations
    /// </summary>
    public int Confirmations { get; init; }

    /// <summary>
    /// number of signatures
    /// </summary>
    public int Signatures { get; init; }

    /// <summary>
    /// anchor status
    /// </summary>
    [JsonProperty("active")]
    public bool? IsActive { get; init; }

    /// <summary>
    /// anchor creation height
    /// </summary>
    public int? AnchorCreationHeight { get; init; }
}
