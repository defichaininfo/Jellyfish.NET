using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.Wallet
{
    public class Wallet
    {
        private readonly IApiClient _client;

        public Wallet(IApiClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Returns the total available balance in wallet.
        /// </summary>
        /// <param name="minimumConfirmation">to include transactions confirmed at least this many times</param>
        /// <param name="includeWatchOnly">for watch-only wallets</param>
        public async Task<decimal> GetBalanceAsync(int minimumConfirmation = 0, bool includeWatchOnly = false)
        {
            return await _client.CallAsync<decimal>("getbalance", "*", minimumConfirmation, includeWatchOnly);
        }

        /// <summary>
        /// Identical to getBalance to get untrusted pending balance
        /// </summary>
        public async Task<decimal> GetUnconfirmedBalanceAsync()
        {
            return await _client.CallAsync<decimal>("getunconfirmedbalance", false);
        }

        /// <summary>
        /// Returns an object with all balances.
        /// </summary>
        public async Task<WalletBalances> GetBalancesAsync()
        {
            return await _client.CallAsync<WalletBalances>("getbalances", false);
        }

        /// <summary>
        /// Get list of UTXOs in wallet.
        /// </summary>
        /// <param name="minimumConfirmations">default = 1, to filter</param>
        /// <param name="maximumConfirmations">default = 9999999, to filter</param>
        public async Task<UTXO[]> ListUnspentAsync(int minimumConfirmations = 1, int maximumConfirmations = 9999999, ListUnspentOptions? options = null)
        {
            options ??= new ListUnspentOptions();
            return await _client.CallAsync<UTXO[]>("listunspent", minimumConfirmations, maximumConfirmations, options.Addresses, options.IncludeUnsafe, options.QueryOptions);
        }

        /// <summary>
        /// Create a new wallet
        /// </summary>
        public async Task<CreateWalletResult> CreateWalletAsync(string walletName, bool disablePrivateKeys = false, CreateWalletOptions? options = null)
        {
            options ??= new CreateWalletOptions();
            return await _client.CallAsync<CreateWalletResult>("createwallet", walletName, disablePrivateKeys, options.IsBlank, options.PassPhrase, options.AvoidReuse);
        }

        /// <summary>
        /// Return object containing various wallet state info
        /// </summary>
        public async Task<WalletInfo> GetWalletInfoAsync()
        {
            return await _client.CallAsync<WalletInfo>("getwalletinfo");
        }

        /// <summary>
        /// Change the state of the given wallet flag for a wallet
        /// </summary>
        /// <param name="flag">flag to change. eg: avoid_reuse</param>
        /// <param name="value">optional, default = true</param>
        public async Task<WalletFlagResult> SetWalletFlagAsync(WalletFlag flag, bool value = true)
        {
            return await _client.CallAsync<WalletFlagResult>("setwalletflag", flag.ToString(), value);
        }

        /// <summary>
        /// Returns a new DeFi address for receiving payments.
        /// If 'label' is specified, it's added to the address book
        /// so payments received with the address will be associated with 'label'
        /// </summary>
        /// <param name="label">for address to be linked to. It can also be set as empty string</param>
        /// <param name="addressType">to use, eg: legacy, p2sh-segwit, bech32</param>
        public async Task<string> GetNewAddressAsync(string label = "", AddressType addressType = AddressType.Bech32)
        {
            return await _client.CallAsync<string>("getnewaddress", label, AddressTypeToString(addressType));
        }

        private string AddressTypeToString(AddressType addressType)
        {
            return addressType switch
            {
                AddressType.P2SHSegwit => "p2sh-segwit",
                _ => addressType.ToString().ToLower()
            };
        }

        /// <summary>
        /// Validate and return information about the given DFI address
        /// </summary>
        public async Task<ValidateAddressResult> ValidateAddressAsync(string address)
        {
            return await _client.CallAsync<ValidateAddressResult>("validateaddress", address);
        }

        /// <summary>
        /// Return information about the given address
        /// </summary>
        public async Task<AddressInfo> GetAddressInfoAsync(string address)
        {
            return await _client.CallAsync<AddressInfo>("getaddressinfo", address);
        }

        /// <summary>
        /// Send an amount to given address and return a transaction id
        /// </summary>
        public async Task<string> SendToAddressAsync(string address, decimal amount, SendToAddressOptions? options = null)
        {
            options ??= new SendToAddressOptions();
            return await _client.CallAsync<string>("sendtoaddress", address, amount, options.Comment, options.CommentTo, options.SubtractFeeFromAmount, options.IsReplaceable, options.ConfirmationTarget, options.EstimateMode.ToString().ToUpper(), options.AvoidReuse);
        }

        /// <summary>
        /// Lists groups of addresses which have had their common ownership made public
        /// by common use as inputs or as the resulting change in past transactions
        /// </summary>
        public async Task<object[][][]> ListAddressGroupingsAsync()
        {
            return await _client.CallAsync<object[][][]>("listaddressgroupings");
        }

        /// <summary>
        /// Send given amounts to multiple given address and return a transaction id.
        /// </summary>
        /// <param name="amounts">Dictionary/map with individual addresses and amounts</param>
        /// <param name="subtractFeeFrom">Array of addresses from which fee needs to be deducted.</param>
        /// <returns>hex string of the transaction</returns>
        public async Task<string> SendManyAsync(Dictionary<string, decimal> amounts, string[]? subtractFeeFrom = null, SendManyOptions? options = null)
        {
            subtractFeeFrom ??= Array.Empty<string>();
            options ??= new SendManyOptions();
            var dummy = string.Empty; // Must be set to '' for backward compatibality.
            var minconf = 0; // Ignored dummy value
            return await _client.CallAsync<string>("sendmany", dummy, amounts, minconf, options.Comment, subtractFeeFrom, options.IsReplaceable, options.ConfirmationTarget, options.EstimateMode.ToString().ToUpper());
        }

        /// <summary>
        /// Reveals the private key corresponding to an address.
        /// </summary>
        /// <param name="address">The DFI address for the private key.</param>
        public async Task<string> DumpPrivateKeyAsync(string address)
        {
            return await _client.CallAsync<string>("dumpprivkey", address);
        }

        /// <summary>
        /// Adds a private key (as returned by dumpprivkey) to your wallet. Requires a new wallet backup.
        /// </summary>
        /// <param name="privateKey">The private key (see dumpprivkey)</param>
        /// <param name="label">current label if address exists, otherwise "".</param>
        /// <param name="rescan">Rescan the wallet for transactions</param>
        /// <returns></returns>
        public async Task ImportPrivateKeyAsync(string privateKey, string label = "", bool rescan = true)
        {
            await _client.CallAsync("importprivkey", privateKey, label, rescan);
        }

        /// <summary>
        /// Get detailed information about in-wallet transaction
        /// </summary>
        /// <param name="transactionId">transaction id</param>
        /// <param name="includeWatchOnly">optional, default = true</param>
        /// <returns></returns>
        public async Task<InWalletTransaction> GetTransaction(uint256 transactionId, bool includeWatchOnly = true)
        {
            return await _client.CallAsync<InWalletTransaction>("gettransaction", transactionId.ToString(), includeWatchOnly);
        }
    }
}