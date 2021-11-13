using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class ValidateAddressResult
{
    public bool IsValid { get; init; }
    public string Address { get; init; } = string.Empty;
    public string ScriptPubKey { get; init; } = string.Empty;
    public bool IsScript { get; init; }
    public bool IsWitness { get; init; }
    [JsonProperty("witness_version")]
    public double WitnessVersion { get; init; }
    [JsonProperty("witness_program")]
    public string WitnessProgram { get; init; } = string.Empty;
}
