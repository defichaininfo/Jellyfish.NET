using Newtonsoft.Json;

namespace Jellyfish.JsonRpc;

public class Request
{
    [JsonProperty("jsonrpc")]
    public string JsonRpc { get; }
    [JsonProperty("id")]
    public double Id { get; }
    [JsonProperty("method")]
    public string Method { get; }
    [JsonProperty("params")]
    public object?[] Parameters { get; }

    public Request(string jsonRpc, double id, string method, params object?[] parameters)
    {
        JsonRpc = jsonRpc;
        Id = id;
        Method = method;
        Parameters = parameters;
    }
}
