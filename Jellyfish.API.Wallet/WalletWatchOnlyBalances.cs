using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class WalletWatchOnlyBalances
{
    public decimal Trusted { get; init; }
    [JsonProperty("untrusted_pending")]
    public decimal UntrustedPending { get; init; }
    public decimal Immature { get; init; }
}
