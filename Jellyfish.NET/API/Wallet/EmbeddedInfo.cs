using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class EmbeddedInfo
{
    public string Address { get; init; } = string.Empty;
    public string ScriptPubKey { get; init; } = string.Empty;
    public bool IsScript { get; init; }
    public bool IsWitness { get; init; }
    [JsonProperty("witness_version")]
    public double WitnessVersion { get; init; }
    [JsonProperty("witness_program")]
    public string WitnessProgram { get; init; } = string.Empty;
    public ScriptType Script { get; init; }
    public string Hex { get; init; } = string.Empty;
    [JsonProperty("sigsrequired")]
    public int RequiredSignatures { get; init; }
    public string PubKey { get; init; } = string.Empty;
    public string[] PubKeys { get; init; } = Array.Empty<string>();
}
