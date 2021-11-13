using Jellyfish.API.Core;

namespace Jellyfish.API.Net;

/// <summary>
/// Net RPCs for DeFi Blockchain
/// </summary>
public class Net
{
    private readonly IApiClient _client;

    public Net(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns the number of connections to other nodes.
    /// </summary>
    public async Task<int> GetConnectionCountAsync()
    {
        return await _client.CallAsync<int>("getconnectioncount");
    }

    /// <summary>
    /// Returns an object containing various state info regarding P2P networking
    /// </summary>
    public async Task<NetworkInfo> GetNetworkInfoAsync()
    {
        return await _client.CallAsync<NetworkInfo>("getnetworkinfo");
    }
}
