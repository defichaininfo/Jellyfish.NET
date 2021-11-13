using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class ChainTip
{
    public int Height { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;
    [JsonProperty("branchlen")]
    public int BranchLength { get; init; }
    public string Status { get; init; } = string.Empty;
}
