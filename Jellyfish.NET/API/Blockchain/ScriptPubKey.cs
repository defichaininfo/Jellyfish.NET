using Newtonsoft.Json;

namespace Jellyfish.API.Blockchain;

public class ScriptPubKey
{
    [JsonProperty("asm")]
    public string Assembly { get; init; } = string.Empty;
    public string Hex { get; init; } = string.Empty;
    public string Type { get; init; } = string.Empty;
    [JsonProperty("reqSigs")]
    public int RequiredSignatures { get; init; }
    public string[] Addresses { get; set; } = Array.Empty<string>();
}
