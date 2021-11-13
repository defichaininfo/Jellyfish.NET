using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public abstract class History
{
    public string Owner { get; init; } = string.Empty;

    public int BlockHeight { get; init; }

    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BlockHash { get; init; } = uint256.Zero;

    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset BlockTime { get; init; }

    public string Type { get; init; } = string.Empty;
    public double Txn { get; init; }

    [JsonProperty("txid")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 TransactionId { get; init; } = uint256.Zero;
    public string[] Amounts { get; init; } = Array.Empty<string>();
}
