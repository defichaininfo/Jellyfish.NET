using Jellyfish.API.Core;

namespace Jellyfish.API.Misc;

public class Misc
{
    private readonly IApiClient _client;

    public Misc(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Set the local time to given timestamp (-regtest only).
    /// Pass 0 to go back to using the system time.
    /// </summary>
    /// <param name="time">Unix seconds-since-epoch timestamp</param>
    public async Task SetMockTimeAsync(double timestamp)
    {
        var ts = timestamp.ToString().Length == 13 ? Math.Floor(timestamp / 1e3) : timestamp;
        await _client.CallAsync("setmocktime", ts);
    }
}
