using Jellyfish.API.Core;

namespace Jellyfish.API.Server;

public class Server
{
    private readonly IApiClient _client;

    public Server(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns details of the RPC server
    /// </summary>
    public async Task<RpcInfo> GetRpcInfoAsync()
    {
        return await _client.CallAsync<RpcInfo>("getrpcinfo");
    }

    /// <summary>
    /// Returns the total uptime of the server in seconds
    /// </summary>
    public async Task<long> UptimeAsync()
    {
        return await _client.CallAsync<long>("uptime");
    }
}
