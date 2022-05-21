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
    /// Returns data about each connected network node as a json array of objects.
    /// </summary>
    public async Task<PeerInfo[]> GetPeerInfoAsync()
    {
        return await _client.CallAsync<PeerInfo[]>("getpeerinfo");
    }

    /// <summary>
    /// Returns an object containing various state info regarding P2P networking
    /// </summary>
    public async Task<NetworkInfo> GetNetworkInfoAsync()
    {
        return await _client.CallAsync<NetworkInfo>("getnetworkinfo");
    }

    /// <summary>
    /// Disable/enable all p2p network activity.
    /// </summary>
    /// <param name="state">state true to enable networking, false to disable</param>
    /// <returns>current network state</returns>
    public async Task<bool> SetNetworkActive(bool state)
    {
        return await _client.CallAsync<bool>("setnetworkactive", state);
    }
}
