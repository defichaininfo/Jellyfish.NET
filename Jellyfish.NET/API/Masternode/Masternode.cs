using Jellyfish.API.Core;
using Jellyfish.Json;
using NBitcoin;
using Newtonsoft.Json.Linq;

namespace Jellyfish.API.Masternode;

/// <summary>
/// Masternode RPCs for DeFi Blockchain
/// </summary>
public class Masternode
{
    private readonly IApiClient _client;

    public Masternode(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a masternode creation transaction with given owner and operator addresses.
    /// </summary>
    /// <param name="ownerAddress">Any valid address for keeping collateral amount</param>
    /// <param name="operatorAddress">Masternode operator auth address (P2PKH only, unique). If empty, owner address will be used.</param>
    public async Task<string> CreateMasternodeAsync(string ownerAddress, string? operatorAddress = null, CreateMasternodeOptions? options = null)
    {
        operatorAddress ??= ownerAddress;
        options ??= new CreateMasternodeOptions();
        var parameters = new List<object?> { ownerAddress, operatorAddress, options.Utxos };
        if (options.TimeLock != null)
        {
            parameters.Add(options.TimeLock);
        }
        return await _client.CallAsync<string>("createmasternode", parameters.ToArray());
    }

    /// <summary>
    /// Returns information about multiple masternodes.
    /// </summary>
    public async Task<MasternodeResult<string>> ListMasternodesAsync(MasternodePagination? pagination = null)
    {
        pagination ??= new MasternodePagination();
        var verbose = false;
        return await _client.CallAsync<MasternodeResult<string>>("listmasternodes", pagination, verbose);
    }

    /// <summary>
    /// Returns information about multiple masternodes.
    /// </summary>
    public async Task<MasternodeResult<MasternodeInfo>> ListMasternodesVerboseAsync(MasternodePagination? pagination = null)
    {
        pagination ??= new MasternodePagination();
        var verbose = true;
        return await _client.CallAsync<MasternodeResult<MasternodeInfo>>("listmasternodes", pagination, verbose);
    }

    /// <summary>
    /// Returns information about a single masternode
    /// </summary>
    /// <param name="masternodeId">The masternode's id.</param>
    public async Task<MasternodeResult<MasternodeInfo>> GetMasternodeAsync(string masternodeId)
    {
        return await _client.CallAsync<MasternodeResult<MasternodeInfo>>("getmasternode", masternodeId);
    }

    /// <summary>
    /// Creates a transaction resigning a masternode.
    /// </summary>
    /// <param name="masternodeId">The masternode's id.</param>
    /// <param name="utxos">Array of specified utxos to spend.</param>
    /// <returns>Resignation Transaction.</returns>
    public async Task<uint256> ResignMasternodeAsync(string masternodeId, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        var transaction = await _client.CallAsync<string>("resignmasternode", masternodeId, utxos);
        return uint256.Parse(transaction);
    }

    /// <summary>
    /// Set special governance variables
    /// </summary>
    /// <param name="key">input json key</param>
    /// <param name="value">input json value</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>hash</returns>
    public async Task<uint256> SetGovernanceVariableAsync(string key, object value, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        var input = new JObject
        {
            { key, JToken.FromObject(value) }
        };
        var hash = await _client.CallAsync<string>("setgov", input, utxos);
        return uint256.Parse(hash);
    }

    /// <summary>
    /// Set special governance variables with activation height specified
    /// </summary>
    /// <param name="key">input json key</param>
    /// <param name="value">input json value</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>hash</returns>
    public async Task<uint256> SetGovHeightAsync(string key, object value, int activationHeight, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        var input = new JObject
        {
            { key, JToken.FromObject(value) }
        };
        var hash = await _client.CallAsync<string>("setgovheight", input, activationHeight, utxos);
        return uint256.Parse(hash);
    }

    /// <summary>
    /// Get information about governance variable
    /// </summary>
    /// <param name="name">governance name</param>
    /// <returns>governance information as json object</returns>
    public async Task<object> GetGovernanceVariablesAsync(string key)
    {
        return await _client.CallAsync<object>("getgov", key);
    }

    /// <summary>
    /// List all governance variables together if any with activation height
    /// </summary>
    public async Task<JObject[][]> ListGovsAsync()
    {
        return await _client.CallAsync<JObject[][]>("listgovs");
    }

    /// <summary>
    /// Returns number of unique masternodes in the last specified number of blocks.
    /// </summary>
    /// <param name="blockCount">The number of blocks to check for unique masternodes.</param>
    /// <returns>Number of unique masternodes seen</returns>
    public async Task<int> GetActiveMasternodeCountAsync(int blockCount = 20160)
    {
        return await _client.CallAsync<int>("getactivemasternodecount", blockCount);
    }
}
