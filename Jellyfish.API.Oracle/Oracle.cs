using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.Oracle;

/**
 * Oracle RPCs for DeFi Blockchain
 */
public class Oracle
{
    private readonly IApiClient _client;

    public Oracle(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a price oracle for rely of real time price data.
    /// </summary>
    /// <returns>oracleId, also the txn id for txn created to appoint oracle</returns>
    public async Task<uint256> AppointOracleAsync(string address, OraclePriceFeed[] priceFeeds, AppointOracleOptions? options = null)
    {
        options ??= new AppointOracleOptions();
        var oracleId = await _client.CallAsync<string>("appointoracle", address, priceFeeds, options.Weightage, options.Utxos);
        return uint256.Parse(oracleId);
    }

    /// <summary>
    /// Update a price oracle for rely of real time price data.
    /// </summary>
    /// <returns>txid</returns>
    public async Task<string> UpdateOracleAsync(uint256 oracleId, string address, UpdateOracleOptions? options = null)
    {
        options ??= new UpdateOracleOptions();
        return await _client.CallAsync<string>("updateoracle", oracleId.ToString(), address, options.PriceFeeds, options.Weightage, options.Utxos);
    }

    /// <summary>
    /// Removes Oracle.
    /// </summary>
    /// <returns>txid</returns>
    public async Task<string> RemoveOracleAsync(uint256 oracleId, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("removeoracle", oracleId.ToString(), utxos);
    }

    /// <summary>
    /// Returns oracle data.
    /// </summary>
    public async Task<OracleData> GetOracleDataAsync(uint256 oracleId)
    {
        return await _client.CallAsync<OracleData>("getoracledata", oracleId.ToString());
    }

    /// <summary>
    /// Set oracle data transaction.
    /// </summary>
    /// <param name="timeStamp">timestamp in seconds</param>
    /// <returns>txid</returns>
    public async Task<string> SetOracleDataAsync(uint256 oracleId, DateTimeOffset time, SetOracleDataOptions? options = null)
    {
        options ??= new SetOracleDataOptions();
        var timeStamp = Utils.DateTimeToUnixTime(time);
        return await _client.CallAsync<string>("setoracledata", oracleId.ToString(), timeStamp, options.Prices, options.Utxos);
    }

    /// <summary>
    /// Returns array of oracle ids.
    /// </summary>
    public async Task<uint256[]> ListOraclesAsync()
    {
        var oracles = await _client.CallAsync<string[]>("listoracles");
        return oracles.Select(o => uint256.Parse(o)).ToArray();
    }

    /// <summary>
    /// Returns latest raw price updates from oracles.
    /// </summary>
    public async Task<OracleRawPrice[]> ListLatestRawPricesAsync(OraclePriceFeed? priceFeed = null)
    {
        if (priceFeed == null)
        {
            return await _client.CallAsync<OracleRawPrice[]>("listlatestrawprices");
        }
        else
        {
            return await _client.CallAsync<OracleRawPrice[]>("listlatestrawprices", priceFeed);
        }
    }

    /// <summary>
    /// Returns aggregated price from oracles.
    /// </summary>
    public async Task<decimal> GetPriceAsync(OraclePriceFeed priceFeed)
    {
        return await _client.CallAsync<decimal>("getprice", priceFeed);
    }

    /// <summary>
    /// List all aggregated prices.
    /// </summary>
    public async Task<ListPricesData[]> ListPricesAsync()
    {
        return await _client.CallAsync<ListPricesData[]>("listprices");
    }

    /// <summary>
    /// Get fixed interval price.
    /// </summary>
    /// <param name="id">Price feed id</param>
    public async Task<FixedIntervalPrice> GetFixedIntervalPriceAsync(string id)
    {
        return await _client.CallAsync<FixedIntervalPrice>("getfixedintervalprice", id);
    }

    /// <summary>
    /// List all fixed interval prices.
    /// </summary>
    public async Task<ListFixedIntervalPrice[]> ListFixedIntervalPricesAsync(FixedIntervalPricePagination? pagination = null)
    {
        pagination ??= new FixedIntervalPricePagination { Limit = 100 };
        return await _client.CallAsync<ListFixedIntervalPrice[]>("listfixedintervalprices", pagination);
    }
}