using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListAnchorAuthsResult
{
    /// <summary>
    /// previous anchor
    /// </summary>
    public string PreviousAnchor { get; init; } = string.Empty;

    /// <summary>
    /// defi block height
    /// </summary>
    public int BlockHeight { get; init; }

    /// <summary>
    /// defi block hash
    /// </summary>
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BlockHash { get; init; } = uint256.Zero;

    /// <summary>
    /// anchor creation height
    /// </summary>
    public int CreationHeight { get; init; }

    /// <summary>
    /// number of anchor signers
    /// </summary>
    public int Signers { get; init; }

    /// <summary>
    /// anchor signees address
    /// </summary>
    public string[]? Signees { get; init; }
}
