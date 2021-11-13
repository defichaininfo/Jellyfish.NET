using Jellyfish.API.Core;
using Jellyfish.API.Core.Exceptions;
using Jellyfish.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Jellyfish.JsonRpc;

public class JsonRpcClient : IApiClient
{
    private readonly string _base64EncodedAuthenticationString;
    private readonly string _url;
    protected HttpClient _httpClient;
    private readonly ClientOptions _clientOptions;

    public JsonRpcClient(string url, ClientOptions? options = null)
    {
        var uri = new Uri(url);
        _base64EncodedAuthenticationString = ParseCredentials(uri);
        _url = ParseUrl(uri);
        _httpClient = new HttpClient();
        _clientOptions = options ?? ClientOptions.Default;
    }

    private string ParseCredentials(Uri uri)
    {
        var authenticationString = uri.UserInfo;
        return Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString));
    }

    private string ParseUrl(Uri uri)
    {
        return $"{uri.Scheme}://{uri.Host}:{uri.Port}";
    }

    public async Task CallAsync(string method, params object?[] args)
    {
        var requestBody = new RequestBody(method, args);
        var body = JellyfishJson.Stringify(requestBody);
        var response = await FetchWithTimeoutAsync(body);

        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
            case HttpStatusCode.NotFound:
            case HttpStatusCode.InternalServerError:
                throw new ClientApiException($"{(int)response.StatusCode} - {response.StatusCode}");
        }
    }

    public async Task<T> CallAsync<T>(string method, params object?[] args)
    {
        var requestBody = new RequestBody(method, args);
        var body = JellyfishJson.Stringify(requestBody);
        var response = await FetchWithTimeoutAsync(body);
        var responseBody = await response.Content.ReadFromJsonAsync<ResponseBody>();

        switch (response.StatusCode)
        {
            case HttpStatusCode.Unauthorized:
            case HttpStatusCode.NotFound:
                throw new ClientApiException($"{(int)response.StatusCode} - {response.StatusCode}");
        }

        if (responseBody?.Result == null)
        {
            throw new ClientApiException("Could not parse the result.");
        }

        var resultAsString = JsonSerializer.Serialize(responseBody.Result);
        return Parse<T>(method, resultAsString);
    }

    private async Task<HttpResponseMessage> FetchWithTimeoutAsync(string body)
    {
        var tokenSource = new CancellationTokenSource(_clientOptions.Timeout);
        tokenSource.Token.ThrowIfCancellationRequested();

        try
        {
            var response = await FetchAsync(body, tokenSource.Token);

            return response;
        }
        catch (OperationCanceledException)
        {
            throw new ClientApiException($"Request aborted due to set timeout of {_clientOptions.Timeout}ms.");
        }
        finally
        {
            tokenSource.Dispose();
        }
    }

    protected async Task<HttpResponseMessage> FetchAsync(string body, CancellationToken token)
    {
        var contentType = "application/json-rpc";
        var request = new HttpRequestMessage(HttpMethod.Post, _url);
        request.Headers.Authorization = new AuthenticationHeaderValue("Basic", _base64EncodedAuthenticationString);

        foreach (var header in _clientOptions.Headers)
        {
            request.Headers.Add(header.Key, header.Value);
        }

        request.Content = new StringContent(body, Encoding.UTF8, contentType);
        //request.Content = JsonContent.Create(body, new MediaTypeHeaderValue(contentType));
        var response = await _httpClient.SendAsync(request, token);
        return response;
    }

    private static T Parse<T>(string method, string text)
    {
        T? parsed;

        try
        {
            parsed = JellyfishJson.Parse<T>(text);
        }
        catch (Exception ex)
        {
            throw new RpcApiException(new Payload(0, ex.Message, method));
        }

        if (parsed == null)
        {
            throw new RpcApiException(new Payload(0, "Could not parse object.", method));
        }

        return parsed;
    }
}
