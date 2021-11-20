namespace Jellyfish.JsonRpc;

public class RequestBody
{
    public string JsonRpc { get; set; }
    public string Method { get; set; }
    public object?[] Params { get; set; }

    public RequestBody(string method, object?[] parameters)
    {
        Method = method;
        Params = parameters;
        JsonRpc = "1.0";
    }
}
