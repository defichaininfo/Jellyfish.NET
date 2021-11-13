namespace Jellyfish.API.Core.Exceptions;

public class Payload
{
    public int Code { get; }
    public string Message { get; }
    public string Method { get; }

    public Payload(int code, string message, string method)
    {
        Code = code;
        Message = message;
        Method = method;
    }
}
