using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.ICXOrderBook;

public class ICXOrderBook
{
    private readonly IApiClient _client;

    public ICXOrderBook(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create and submits an ICX order creation transaction.
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the result transaction</returns>
    public async Task<ICXGenericResult> CreateOrderAsync(ICXOrder order, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>("icx_createorder", order, utxos);
    }

    /// <summary>
    /// Create and submits a makeoffer transaction
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> MakeOfferAsync(ICXOffer offer, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>("icx_makeoffer", offer, utxos);
    }

    /// <summary>
    /// Closes offer transaction.
    /// </summary>
    /// <param name="offerTransaction">Transaction Id of maker offer</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> CloseOfferAsync(string offerTransaction, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>(offerTransaction, utxos);
    }

    /// <summary>
    /// Create and submit a DFC HTLC transaction
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> SubmitDFCHTLCAsync(HTLC htlc, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>("icx_submitdfchtlc", htlc, utxos);
    }

    /// <summary>
    /// Create and submit an external(EXT) HTLC transaction
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> SubmitExtHTLCAsync(ExternalHTLC htlc, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>("icx_submitexthtlc", htlc, utxos);
    }

    /// <summary>
    /// Claims a DFC HTLC
    /// </summary>
    /// <param name="dfcHTLCTransactionId">Transaction id of DFC HTLC transaction for which the claim is</param>
    /// <param name="seed">Secret seed for claiming HTLC</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object including transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> ClaimDFCHTLCAsync(string dfcHTLCTransactionId, string seed, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        var htlc = new
        {
            dfcHTLCTransactionId,
            seed
        };
        return await _client.CallAsync<ICXGenericResult>("icx_claimdfchtlc", htlc, utxos);
    }

    /// <summary>
    /// Closes ICX order
    /// </summary>
    /// <param name="orderTransaction">Transaction id of maker order</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>Object indluding transaction id of the the transaction</returns>
    public async Task<ICXGenericResult> CloseOrderAsync(uint256 orderTransaction, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<ICXGenericResult>("icx_closeorder", orderTransaction.ToString(), utxos);
    }

    /// <summary>
    /// Returns information about order or fillorder
    /// </summary>
    /// <param name="orderTransaction">Transaction id of createorder or fulfillorder transaction</param>
    /// <returns>Object including details of the transaction</returns>
    public async Task<ICXGetOrderResult> GetOrderAsync(uint256 orderTransaction)
    {
        return await _client.CallAsync<ICXGetOrderResult>("icx_getorder", orderTransaction.ToString());
    }

    /// <summary>
    /// Returns information about orders or fillorders based on ICXListOrderOptions passed
    /// </summary>
    /// <returns>Object including details of the transaction</returns>
    public async Task<ICXListOrdersResult> ListOrdersAsync(ICXListOrderOptions? options = null)
    {
        options ??= new ICXListOrderOptions();
        return await _client.CallAsync<ICXListOrdersResult>("icx_listorders", options);
    }

    public async Task<ListHTLCsResult> ListHTLCsAsync(ICXListHTLCsOptions options)
    {
        return await _client.CallAsync<ListHTLCsResult>("icx_listhtlcs", options);
    }
}
