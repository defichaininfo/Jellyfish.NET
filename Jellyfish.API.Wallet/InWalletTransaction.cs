using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class InWalletTransaction
{
    public decimal Amount { get; init; }
    public double Fee { get; init; }
    public int Confirmations { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BockHash { get; init; } = uint256.Zero;
    public int BlockIndex { get; init; }
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset BlockTime { get; init; }
    [JsonProperty("txid")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 TransactionId { get; init; } = uint256.Zero;
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset Time { get; init; }
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset TimeReceived { get; init; }
    public Bip125 Bip125Replaceable { get; init; }
    public InWalletTransactionDetail[] Details { get; init; } = Array.Empty<InWalletTransactionDetail>();
    public string Hex { get; init; } = string.Empty;
}
