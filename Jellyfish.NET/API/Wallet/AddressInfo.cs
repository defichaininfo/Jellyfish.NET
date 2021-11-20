using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class AddressInfo
{
    public string Address { get; init; } = string.Empty;
    public string ScriptPubKey { get; init; } = string.Empty;
    public bool IsMine { get; init; }
    public bool IsWatchOnly { get; init; }
    [JsonProperty("solvable")]
    public bool IsSolvable { get; init; }
    [JsonProperty("desc")]
    public string Description { get; init; } = string.Empty;
    public bool IsScript { get; init; }
    public bool IsChange { get; init; } = true;
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
    public EmbeddedInfo Embedded { get; init; } = new EmbeddedInfo();
    public bool IsCompressed { get; init; }
    public string Label { get; init; } = string.Empty;
    public double TimeStamp { get; init; }
    public string HdKeyPath { get; init; } = string.Empty;
    public string HdSeedId { get; init; } = string.Empty;
    public string HdMasterFingerprint { get; init; } = string.Empty;
    public Label[] Labels { get; init; } = Array.Empty<Label>();
}
