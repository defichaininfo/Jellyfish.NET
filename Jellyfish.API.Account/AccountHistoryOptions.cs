using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public class AccountHistoryOptions : HistoryOptions
{
    /// <summary>
    /// Filter out rewards
    /// </summary>
    [JsonProperty("no_rewards")]
    public bool? NoRewards { get; init; }
}
