namespace Jellyfish.API.Core.Exceptions;

public class RpcApiException : ApiException
{
    public Payload Payload { get; }

    public RpcApiException(Payload payload) : base($"RpcApiError: '{payload.Message}', code: {payload.Code}, method: {payload.Method}")
    {
        Payload = payload;
    }
}
