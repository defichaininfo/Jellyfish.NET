using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class WaitBlockResult
{
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 Hash { get; init; } = uint256.Zero;
    public int Height { get; init; }
}
