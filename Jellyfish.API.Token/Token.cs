using Jellyfish.API.Core;

namespace Jellyfish.API.Token;

/// <summary>
/// Token RPCs for DeFi Blockchain
/// </summary>
public class Token
{
    private readonly IApiClient _client;

    public Token(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a token with given metadata
    /// </summary>
    /// <param name="utxos">array of specific UTXOs to spend</param>
    public async Task<string> CreateTokenAsync(CreateTokenMetadata metadata, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("createtoken", metadata, utxos);
    }

    /// <summary>
    /// Updates a token with given metadata
    /// </summary>
    /// <param name="token">symbolKey, id ror creation tx</param>
    public async Task<string> UpdateTokenAsync(string token, UpdateTokenMetadata metadata)
    {
        return await _client.CallAsync<string>("updatetoken", token, metadata);
    }

    /// <summary>
    /// Returns information about tokens
    /// </summary>
    public async Task<TokenResult> ListTokensAsync(TokenPagination? pagination = null, bool verbose = true)
    {
        pagination ??= new TokenPagination();
        return await _client.CallAsync<TokenResult>("listtokens", pagination, verbose);
    }

    /// <summary>
    /// Return information about token
    /// </summary>
    public async Task<TokenResult> GetTokenAsync(string symbolKey)
    {
        return await _client.CallAsync<TokenResult>("gettoken", symbolKey);
    }

    /// <summary>
    /// Creates a transaction to mint tokens.
    /// </summary>
    /// <param name="amountToken">formatted as '${number}@${string}'</param>
    public async Task<string> MintTokensAsync(string amountToken, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("minttokens", amountToken, utxos);
    }
}
