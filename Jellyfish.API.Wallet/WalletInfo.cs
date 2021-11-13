using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class WalletInfo
{
    public string WalletName { get; init; } = string.Empty;
    public double WalletVersion { get; init; }
    public decimal Balance { get; init; }
    [JsonProperty("unconfirmed_balance")]
    public decimal UnconfirmedBalance { get; init; }
    [JsonProperty("immature_balance")]
    public decimal ImmatureBalance { get; init; }
    [JsonProperty("txcount")]
    public int TransactionCount { get; init; }
    public double KeyPoolOldest { get; init; }
    public double KeyPoolSize { get; init; }
    [JsonProperty("keypoolsize_hd_internal")]
    public double KeyPoolSizeHdInternal { get; init; }
    [JsonProperty("unlocked_until")]
    public double UnlockedUntil { get; init; }
    [JsonProperty("paytxfee")]
    public decimal PayTransactionFee { get; init; }
    public string HdSeedId { get; init; } = string.Empty;
    [JsonProperty("private_keys_enabled")]
    public bool PrivateKeysEnabled { get; init; }
    [JsonProperty("avoid_reuse")]
    public bool AvoidReuse { get; init; }
    public Scanning Scanning { get; init; } = new Scanning();
}
