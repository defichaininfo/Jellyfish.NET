using Newtonsoft.Json;

namespace Jellyfish.API.Net;

public class NetworkInfo
{
    public int Version { get; init; }
    public string Subversion { get; init; } = string.Empty;
    public int ProtocolVersion { get; init; }
    public string LocalServices { get; init; } = string.Empty;
    [JsonProperty("localrelay")]
    public bool IsLocalRelay { get; init; }
    public double TimeOffset { get; init; }
    public int Connections { get; init; }
    [JsonProperty("networkactive")]
    public bool IsNetworkActive { get; init; }
    public Network[] Networks { get; init; } = Array.Empty<Network>();
    public decimal RelayFee { get; init; }
    public decimal IncrementalFee { get; init; }
    public LocalAddress[] LocalAddresses { get; init; } = Array.Empty<LocalAddress>();
    public string Warnings { get; init; } = string.Empty;
}
