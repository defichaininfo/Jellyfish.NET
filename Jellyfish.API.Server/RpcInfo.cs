using Newtonsoft.Json;

namespace Jellyfish.API.Server;

public class RpcInfo
{
    [JsonProperty("active_commands")]
    public ActiveCommand[] ActiveCommands { get; init; } = Array.Empty<ActiveCommand>();
    public string LogPath { get; init; } = string.Empty;
}
