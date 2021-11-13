using Jellyfish.API.Core;

namespace Jellyfish.API.PoolPair;

/// <summary>
/// PoolPair RPCs for DeFi Blockchain
/// </summary>
public class PoolPair
{
    private readonly IApiClient _client;

    public PoolPair(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create a poolpair with given metadata
    /// </summary>
    /// <param name="metadata">metadata a data providing information for pool pair creation</param>
    /// <param name="utxos">is an array of specific UTXOs to spend</param>
    public async Task<string> CreatePoolPairAsync(CreatePoolPairMetadata metadata, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("createpoolpair", metadata, utxos);
    }

    /// <summary>
    /// Returns information about pools
    /// </summary>
    /// <param name="verbose">default = true, otherwise only symbol, name, status, idTokenA, idTokenB</param>
    public async Task<PoolPairsResult> ListPoolPairsAsync(PoolPairPagination? pagination = null, bool verbose = true)
    {
        pagination ??= new PoolPairPagination();
        return await _client.CallAsync<PoolPairsResult>("listpoolpairs", pagination, verbose);
    }

    /// <summary>
    /// Returns information about pool
    /// </summary>
    /// <param name="symbol">symbol token's symbol</param>
    /// <param name="verbose">verbose default = true, otherwise only symbol, name, status, idTokenA, idTokenB</param>
    /// <returns></returns>
    public async Task<PoolPairsResult> GetPoolPairAsync(string symbol, bool verbose = true)
    {
        return await _client.CallAsync<PoolPairsResult>("getpoolpair", symbol, verbose);
    }

    /// <summary>
    /// Add pool liquidity transaction
    /// </summary>
    /// <param name="from">pool liquidity sources</param>
    /// <param name="shareAddress">defi address for crediting tokens</param>
    /// <param name="utxos">utxos array of specific UTXOs to spend</param>
    public async Task<string> AddPoolLiquidityAsync(AddPoolLiquiditySource from, string shareAddress, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("addpoolliquidity", from, shareAddress, utxos);
    }

    /// <summary>
    /// Returns information about pool shares
    /// </summary>
    /// <param name="verbose">default = true, otherwise only poolID, owner and %</param>
    public async Task<PoolSharesResult> ListPoolSharesAsync(PoolPairPagination? pagination = null, bool verbose = true, bool isMineOnly = true)
    {
        pagination ??= new PoolPairPagination();
        return await _client.CallAsync<PoolSharesResult>("listpoolshares", pagination, verbose, isMineOnly);
    }

    /// <summary>
    /// Creates a pool swap transaction with given metadata
    /// </summary>
    /// <param name="metadata">a provided information to create pool swap transaction</param>
    /// <param name="utxos">array for utxos to spend from.</param>
    /// <returns>hex of performed transaction</returns>
    public async Task<string> PoolSwapAsync(PoolSwapMetadata metadata, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("poolswap", metadata, utxos);
    }

    /// <summary>
    /// Create a test pool swap transaction to check pool swap's return result
    /// </summary>
    /// <param name="metadata">a provided information to create test pool swap transaction</param>
    /// <returns>formatted as 'amount@token' swapped</returns>
    public async Task<string> TestPoolSwapAsync(PoolSwapMetadata metadata)
    {
        return await _client.CallAsync<string>("testpoolswap", metadata);
    }

    /// <summary>
    /// Remove pool liquidity transaction
    /// </summary>
    /// <param name="address">defi address for crediting tokens</param>
    /// <param name="poolAccount">pool liquidity account of owner</param>
    /// <param name="utxos">utxos array of specific UTXOs to spend</param>
    public async Task<string> RemovePoolLiquidityAsync(string address, string poolAccount, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("removepoolliquidity", address, poolAccount, utxos);
    }
}