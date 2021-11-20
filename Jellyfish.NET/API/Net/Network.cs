using Newtonsoft.Json;

namespace Jellyfish.API.Net;

public class Network
{
    public string Name { get; init; } = string.Empty;
    [JsonProperty("limited")]
    public bool IsLimited { get; init; }
    [JsonProperty("reachable")]
    public bool IsReachable { get; init; }
    public string Proxy { get; init; } = string.Empty;
    [JsonProperty("proxy_randomize_credentials")]
    public bool ProxyRandomizeCredentials { get; init; }
}
