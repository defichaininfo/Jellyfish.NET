using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public class AccountOwner
{
    public string Asm { get; init; } = string.Empty;
    [JsonProperty("reqSigs")]
    public string Hex { get; init; } = string.Empty;
    public int RequiredSignatures { get; init; }
    public string Type { get; init; } = string.Empty;
    public string[] Addresses { get; init; } = Array.Empty<string>();
}
