using System.Net.Http.Headers;

namespace Jellyfish.JsonRpc;

/// <summary>
/// ClientOptions for JsonRpc
/// </summary>
public class ClientOptions
{
    /// <summary>
    /// Millis before RPC request is aborted.
    /// The default is 60000 ms.
    /// </summary>
    public int Timeout { get; }

    /// <summary>
    /// Headers to include in the RPC request
    /// </summary>
    public IEnumerable<KeyValuePair<string, string>> Headers { get; }

    public static ClientOptions Default { get; } = new ClientOptions();

    public ClientOptions(int timeout = 60000, IEnumerable<KeyValuePair<string, string>>? headers = null)
    {
        Timeout = timeout;
        Headers = headers ?? Array.Empty<KeyValuePair<string, string>>();
    }
}
