using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class WalletFlagResult
{
    [JsonProperty("flag_name")]
    public string FlagName { get; init; } = string.Empty;
    [JsonProperty("flag_state")]
    public bool FlagState { get; init; }
    public string Warnings { get; init; } = string.Empty;
}
