using Jellyfish.API.Core;

namespace Jellyfish.API.Account;

/**
 * Account RPCs for DeFi Blockchain
 */
public class Account
{
    private readonly IApiClient _client;

    public Account(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get information about all accounts on chain
    /// </summary>
    /// <param name="isMineOnly">get balances about all accounts belonging to the wallet</param>
    /// <returns>account with hex-encoded owner info, addresses and amount with tokenId</returns>
    public async Task<AccountResult<string, string>[]> ListAccountsAsync(AccountPagination? pagination = null, bool isMineOnly = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var isVerbose = false;
        var withIndexedAmounts = false;
        return await _client.CallAsync<AccountResult<string, string>[]>("listaccounts", pagination, isVerbose, withIndexedAmounts, isMineOnly);
    }

    /// <summary>
    /// Get information about all accounts on chain
    /// </summary>
    /// <param name="isMineOnly">get balances about all accounts belonging to the wallet</param>
    /// <returns>account with object owner info, addresses and amount with tokenId</returns>
    public async Task<AccountResult<AccountOwner, string>[]> ListAccountsVerboseAsync(AccountPagination? pagination = null, bool isMineOnly = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var isVerbose = true;
        var withIndexedAmounts = false;
        return await _client.CallAsync<AccountResult<AccountOwner, string>[]>("listaccounts", pagination, isVerbose, withIndexedAmounts, isMineOnly);
    }

    /// <summary>
    /// Get information about all accounts on chain
    /// </summary>
    /// <param name="isMineOnly">get balances about all accounts belonging to the wallet</param>
    /// <returns>account with hex-encoded owner info, addresses and object with indexed amount</returns>
    public async Task<AccountResult<string, AccountAmount>[]> ListAccountsWithIndexedAmountsAsync(AccountPagination? pagination = null, bool isMineOnly = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var isVerbose = false;
        var withIndexedAmounts = true;
        return await _client.CallAsync<AccountResult<string, AccountAmount>[]>("listaccounts", pagination, isVerbose, withIndexedAmounts, isMineOnly);
    }

    /// <summary>
    /// Get information about all accounts on chain
    /// </summary>
    /// <param name="isMineOnly">get balances about all accounts belonging to the wallet</param>
    /// <returns>account with object owner info, addresses and object with indexed amount</returns>
    public async Task<AccountResult<AccountOwner, AccountAmount>[]> ListAccountsWithIndexedAmountsVerboseAsync(AccountPagination? pagination = null, bool isMineOnly = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var isVerbose = true;
        var withIndexedAmounts = true;
        return await _client.CallAsync<AccountResult<AccountOwner, AccountAmount>[]>("listaccounts", pagination, isVerbose, withIndexedAmounts, isMineOnly);
    }

    /// <summary>
    /// Get information about account. format of amount output: amount@tokenid
    /// </summary>
    /// <param name="owner">address in base58/bech32/hex encoding</param>
    /// <returns>an array of amount with tokenId</returns>
    public async Task<string[]> GetAccountAsync(string owner, AccountPagination? pagination = null)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var withIndexedAmounts = false;
        return await _client.CallAsync<string[]>("getaccount", owner, pagination, withIndexedAmounts);
    }

    /// <summary>
    /// Get information about account.
    /// </summary>
    /// <param name="owner">address in base58/bech32/hex encoding</param>
    /// <returns>an array of amount with index</returns>
    public async Task<AccountAmount> GetAccountWithIndexedAmountsAsync(string owner, AccountPagination? pagination = null)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var withIndexedAmounts = true;
        return await _client.CallAsync<AccountAmount>("getaccount", owner, pagination, withIndexedAmounts);
    }

    /// <summary>
    /// Get the balances of all accounts that belong to the wallet
    /// </summary>
    /// <param name="symbolLookup"> use token symbols in output, default = false</param>
    /// <returns>an array of amount with index</returns>
    public async Task<string[]> GetTokenBalancesAsync(AccountPagination? pagination = null, bool symbolLookup = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var withIndexedAmounts = false;
        return await _client.CallAsync<string[]>("gettokenbalances", pagination, withIndexedAmounts, symbolLookup);
    }

    /// <summary>
    /// Get the balances of all accounts that belong to the wallet
    /// </summary>
    /// <param name="symbolLookup"> use token symbols in output, default = false</param>
    /// <returns>object amount with index</returns>
    public async Task<AccountAmount> GetTokenBalancesWithIndexedAmountsAsync(AccountPagination? pagination = null, bool symbolLookup = false)
    {
        pagination ??= new AccountPagination { Limit = 100 };
        var withIndexedAmounts = true;
        return await _client.CallAsync<AccountAmount>("gettokenbalances", pagination, withIndexedAmounts, symbolLookup);
    }

    /// <summary>
    /// Create a UTXOs to Account transaction submitted to a connected node.
    /// Optionally, specific UTXOs to spend to create that transaction.
    /// </summary>
    public async Task<string> UtxosToAccountAsync(BalanceTransferPayload payload, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("utxostoaccount", payload, utxos);
    }

    /// <summary>
    /// Create an Account to Account transaction submitted to a connected node.
    /// Optionally, specific UTXOs to spend to create that transaction.
    /// </summary>
    public async Task<string> AccountToAccountAsync(string from, BalanceTransferPayload payload, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("accounttoaccount", from, payload, utxos);
    }

    /// <summary>
    /// Create an Account to UTXOS transaction submitted to a connected node.
    /// Optionally, specific UTXOs to spend to create that transaction.
    /// </summary>
    public async Task<string> AccountToUtxosAsync(string from, BalanceTransferPayload payload, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("accounttoutxos", from, payload, utxos);
    }

    /// <summary>
    /// Returns information about account history
    /// </summary>
    /// <param name="owner">single account ID (CScript or address) or reserved words 'mine' to list history for all owned accounts or 'all' to list whole DB</param>
    public async Task<AccountHistory[]> ListAccountHistoryAsync(string? owner = null, HistoryOptions? options = null)
    {
        owner ??= "mine";
        options ??= new AccountHistoryOptions { Limit = 100 };
        return await _client.CallAsync<AccountHistory[]>("listaccounthistory", owner, options);
    }

    /// <summary>
    /// Returns information about account history
    /// </summary>
    public async Task<AccountHistory[]> ListAccountHistoryAsync(OwnerType owner, HistoryOptions? options = null)
    {
        options ??= new AccountHistoryOptions { Limit = 100 };
        return await _client.CallAsync<AccountHistory[]>("listaccounthistory", owner.ToString().ToLower(), options);
    }

    /// <summary>
    /// Returns information about single account history
    /// </summary>
    /// <param name="owner">Single account ID (CScript or address)</param>
    /// <param name="blockHeight">Block height to search in</param>
    /// <param name="txn">Order in block</param>
    public async Task<AccountHistory> GetAccountHistoryAsync(string owner, int blockHeight, decimal txn)
    {
        return await _client.CallAsync<AccountHistory>("getaccounthistory", owner, blockHeight, txn);
    }

    /// <summary>
    /// Returns count of account history
    /// </summary>
    /// <param name="owner">single account ID (CScript or address) or reserved words 'mine' to list history for all owned accounts or 'all' to list whole DB</param>
    public async Task<int> HistoryCountAsync(string? owner = null, AccountHistoryCountOptions? options = null)
    {
        owner ??= "mine";
        options ??= new AccountHistoryCountOptions { };
        return await _client.CallAsync<int>("accounthistorycount", owner, options);
    }

    /// <summary>
    /// Returns count of account history
    /// </summary>
    public async Task<int> HistoryCountAsync(OwnerType ownerType, AccountHistoryCountOptions? options = null)
    {
        var owner = ownerType.ToString().ToLower();
        options ??= new AccountHistoryCountOptions { };
        return await _client.CallAsync<int>("accounthistorycount", owner, options);
    }

    /// <summary>
    /// Creates a transfer transaction from your accounts balances.
    /// </summary>
    /// <param name="from">source address as the key, the value is amount formatted as amount@token</param>
    /// <param name="to">address as the key, the value is amount formatted as amount@token</param>
    /// <param name="selectionMode">Account selection mode. If "from" param is empty, it will auto select.</param>
    public async Task<string> SendTokensToAddress(AddressBalances from, AddressBalances to, SelectionModeType selectionMode = SelectionModeType.Pie)
    {
        return await _client.CallAsync<string>("sendtokenstoaddress", from, to, selectionMode.ToString().ToLower());
    }

    /// <summary>
    /// Returns information about current anchor bonus, incentive funding, burnt token(s)
    /// </summary>
    public async Task<CommunityBalances> ListCommunityBalancesAsync()
    {
        return await _client.CallAsync<CommunityBalances>("listcommunitybalances");
    }

    /// <summary>
    /// Returns information about burn history
    /// </summary>
    public async Task<BurnHistory[]> ListBurnHistoryAsync(BurnHistoryOptions? options = null)
    {
        options ??= new BurnHistoryOptions { Limit = 100 };
        return await _client.CallAsync<BurnHistory[]>("listburnhistory", options);
    }

    /// <summary>
    /// Returns burn address, burnt coin and token information.
    /// Requires full acindex for correct amount, tokens and feeburn values.
    /// </summary>
    public async Task<BurnInfo> GetBurnInfoAsync()
    {
        return await _client.CallAsync<BurnInfo>("getburninfo");
    }

    /// <summary>
    /// Creates and submits to the network a futures contract.
    /// </summary>
    public async Task<string> FutureSwapAsync(FutureSwap future, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("futureswap", future.Address, future.Amount, future.Destination, utxos);
    }

    /// <summary>
    /// Get specific pending futures.
    /// </summary>
    public async Task<GetFutureInfo> GetPendingFutureSwapsAsync(string address)
    {
        return await _client.CallAsync<GetFutureInfo>("getpendingfutureswaps", address);
    }

    /// <summary>
    /// List all pending futures.
    /// </summary>
    public async Task<ListFutureInfo[]> ListPendingFutureSwapsAsync()
    {
        return await _client.CallAsync<ListFutureInfo[]>("listpendingfutureswaps");
    }
}
