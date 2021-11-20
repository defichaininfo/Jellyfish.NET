using System.Text.Json.Serialization;

namespace Jellyfish.API.Blockchain;

public class SoftFork
{
    public string Id { get; set; }
    public SoftForkType Type { get; init; }
    [JsonPropertyName("active")]
    public bool IsActive { get; init; }
    public uint Height { get; init; }

    public SoftFork(string id)
    {
        Id = id;
    }
}
