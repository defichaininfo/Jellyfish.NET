﻿using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.Blockchain;

/**
 * Blockchain RPCs for DeFi Blockchain
 */
public class Blockchain
{
    private readonly IApiClient _client;

    public Blockchain(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get various state info regarding blockchain processing.
    /// </summary>
    public async Task<BlockchainInfo> GetBlockchainInfoAsync()
    {
        return await _client.CallAsync<BlockchainInfo>("getblockchaininfo");
    }

    /// <summary>
    /// Get a hash of block in best-block-chain at height provided.
    /// </summary>
    public async Task<uint256> GetBlockHashAsync(int height)
    {
        var hashAsString = await _client.CallAsync<string>("getblockhash", height);
        return uint256.Parse(hashAsString);
    }

    /// <summary>
    /// Get the height of the most-work fully-validated chain.
    /// </summary>
    public async Task<int> GetBlockCountAsync()
    {
        return await _client.CallAsync<int>("getblockcount");
    }

    /// <summary>
    /// Get block string hex with a provided block header hash.
    /// </summary>
    /// <returns>block as string that is serialized, hex-encoded data</returns>
    public async Task<string> GetBlockHexAsync(uint256 hash)
    {
        var verbosity = 0;
        return await _client.CallAsync<string>("getblock", hash.ToString(), verbosity);
    }

    /// <summary>
    /// Get block data with a provided block header hash.
    /// </summary>
    /// <returns>block information with transaction as txid</returns>
    public async Task<Block<string>> GetBlockAsync(uint256 hash)
    {
        var verbosity = 1;
        return await _client.CallAsync<Block<string>>("getblock", hash.ToString(), verbosity);
    }

    /// <summary>
    /// Get block data with a provided block header hash.
    /// </summary>
    /// <returns>block information and detailed information about each transaction.</returns>
    public async Task<Block<Transaction>> GetBlockVerboseAsync(uint256 hash)
    {
        var verbosity = 2;
        return await _client.CallAsync<Block<Transaction>>("getblock", hash.ToString(), verbosity);
    }

    /// <summary>
    /// Get block header data with particular header hash.
    /// </summary>
    /// <returns>string that is serialized, hex-encoded data for block header.</returns>
    public async Task<string> GetBlockHeaderAsync(uint256 hash)
    {
        var isVerbose = false;
        return await _client.CallAsync<string>("getblockheader", hash.ToString(), isVerbose);
    }

    /// <summary>
    /// Get block header data with particular header hash.
    /// </summary>
    /// <returns>Object with information for block header.</returns>
    public async Task<BlockHeader> GetBlockHeaderVerboseAsync(uint256 hash)
    {
        var isVerbose = true;
        return await _client.CallAsync<BlockHeader>("getblockheader", hash.ToString(), isVerbose);
    }

    /// <summary>
    /// Return information about all known tips in the block tree
    /// including the main chain as well as orphaned branches.
    /// </summary>
    public async Task<ChainTip[]> GetChainTipsAsync()
    {
        return await _client.CallAsync<ChainTip[]>("getchaintips");
    }

    /// <summary>
    /// Get the proof-of-work difficulty as a multiple of the minimum difficulty.
    /// </summary>
    public async Task<double> GetDifficultyAsync()
    {
        return await _client.CallAsync<double>("getdifficulty");
    }

    /// <summary>
    /// Get details of unspent transaction output (UTXO).
    /// </summary>
    /// <param name="txid">the transaction id</param>
    /// <param name="vout">vout number</param>
    /// <param name="includeMemPool">default true, whether to include mempool</param>
    public async Task<UTXODetails> GetTxOutAsync(string txid, uint vout, bool includeMemPool = true)
    {
        return await _client.CallAsync<UTXODetails>("gettxout", txid, vout, includeMemPool);
    }

    /// <summary>
    /// Get all transaction ids in memory pool as string
    /// </summary>
    public async Task<string[]> GetRawMempoolAsync()
    {
        var isVerbose = false;
        return await _client.CallAsync<string[]>("getrawmempool", isVerbose);
    }

    /// <summary>
    /// Get all transaction ids in memory pool as json object
    /// </summary>
    public async Task<MempoolTransaction> GetRawMempoolVerboseAsync()
    {
        var isVerbose = true;
        return await _client.CallAsync<MempoolTransaction>("getrawmempool", isVerbose);
    }

    /// <summary>
    /// Get block statistics for a given window.
    /// </summary>
    /// <param name="hash">The block hash of the target block.</param>
    public async Task<BlockStats> GetBlockStatsAsync(uint256 hash)
    {
        return await _client.CallAsync<BlockStats>("getblockstats", hash.ToString());
    }

    /// <summary>
    /// Get block statistics for a given window.
    /// </summary>
    /// <param name="hash">The block height of the target block.</param>
    public async Task<BlockStats> GetBlockStatsAsync(int height)
    {
        return await _client.CallAsync<BlockStats>("getblockstats", height);
    }

    /// <summary>
    /// Get the hash of the best (tip) block in the most-work fully-validated chain.
    /// </summary>
    public async Task<uint256> GetBestBlockHashAsync()
    {
        var hashAsString = await _client.CallAsync<string>("getbestblockhash");
        return uint256.Parse(hashAsString);
    }

    /// <summary>
    /// Returns details on the active state of the TX memory pool.
    /// </summary>
    public async Task<MempoolInfo> GetMempoolInfo()
    {
        return await _client.CallAsync<MempoolInfo>("getmempoolinfo");
    }
}
