namespace Jellyfish.API.Core;

public interface IApiClient
{
    Task CallAsync(string method, params object?[] args);
    Task<T> CallAsync<T>(string method, params object?[] args);
}