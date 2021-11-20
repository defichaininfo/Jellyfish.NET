namespace Jellyfish.API.Core.Exceptions;

public class ClientApiException : ApiException
{
    public ClientApiException(string message) : base($"ClientApiError: {message}")
    {

    }
}
