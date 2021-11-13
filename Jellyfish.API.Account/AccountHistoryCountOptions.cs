using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public class AccountHistoryCountOptions
{
    /// <summary>
    /// Filter by token
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Filter by transaction type. See <see cref="DfTxType"/>.
    /// </summary>
    [JsonProperty("txtype")]
    public string? TransactionType { get; init; }

    /// <summary>
    /// Filter out rewards
    /// </summary>
    [JsonProperty("no_rewards")]
    public bool? NoRewards { get; init; }
}
