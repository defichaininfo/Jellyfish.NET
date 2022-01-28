using Jellyfish.API.Core;

namespace Jellyfish.API.SPV
{
    /// <summary>
    /// SPV RPCs for Bitcoin Blockchain
    /// </summary>
    public class SPV
    {
        private readonly IApiClient _client;

        public SPV(IApiClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Creates and adds a Bitcoin address to the SPV wallet.
        /// </summary>
        /// <returns>Returns a new Bitcoin address</returns>
        public async Task<string> GetNewAddressAsync()
        {
            return await _client.CallAsync<string>("spv_getnewaddress");
        }

        /// <summary>
        /// Returns a Bitcoin address's public key.
        /// </summary>
        /// <param name="address">Bitcoin address</param>
        /// <returns>Public key</returns>
        public async Task<string> GetAddressPubKeyAsync(string address)
        {
            return await _client.CallAsync<string>("spv_getaddresspubkey", address);
        }

        /// <summary>
        /// List balances by receiving address.
        /// </summary>
        /// <param name="minConfirmations">The minimum number of confirmations</param>
        /// <param name="address">Filter by address</param>
        /// <returns></returns>
        public async Task<ReceivedByAddressInfo[]> ListReceivedByAddressAsync(int minConfirmations = 1, string? address = null)
        {
            return await _client.CallAsync<ReceivedByAddressInfo[]>("spv_listreceivedbyaddress", minConfirmations, address);
        }

        /// <summary>
        /// Send a Bitcoin amount to a given address.
        /// </summary>
        /// <param name="address">Bitcoin address</param>
        /// <param name="amount">Bitcoin amount</param>
        /// <param name="feeRate">Fee rate in satoshis per KB. Minimum is 1000.</param>
        public async Task<SendMessageResult> SendToAddressAsync(string address, decimal amount, decimal feeRate = 10000)
        {
            return await _client.CallAsync<SendMessageResult>("spv_sendtoaddress", address, amount, feeRate);
        }

        /// <summary>
        /// Creates a Bitcoin address whose funds can be unlocked with a seed or as a refund.
        /// </summary>
        /// <param name="receiverPubKey">The public key of the possessor of the seed</param>
        /// <param name="ownerPubKey">The public key of the recipient of the refund</param>
        public async Task<CreateHtlcResult> CreateHtlcAsync(string receiverPubKey, string ownerPubKey, CreateHtlcOptions options)
        {
            return await _client.CallAsync<CreateHtlcResult>("spv_createhtlc", receiverPubKey, ownerPubKey, options.Timeout, options.SeedHash);
        }

        /// <summary>
        /// Decode and return value in a HTLC redeemscript.
        /// </summary>
        /// <param name="redeemScript">HTLC redeem script</param>
        public async Task<DecodeHtlcResult> DecodeHtlcScriptAsync(string redeemScript)
        {
            return await _client.CallAsync<DecodeHtlcResult>("spv_decodehtlcscript", redeemScript);
        }

        /// <summary>
        /// Claims all coins in HTLC address.
        /// </summary>
        /// <param name="scriptAddress">HTLC address</param>
        /// <param name="destinationAddress">Destination address to send HTLC funds to</param>
        public async Task<SendMessageResult> ClaimHtlcAsync(string scriptAddress, string destinationAddress, ClaimHtlcOptions options)
        {
            return await _client.CallAsync<SendMessageResult>("spv_claimhtlc", scriptAddress, destinationAddress, options.Seed, options.FeeRate);
        }

        /// <summary>
        /// Returns the HTLC secret if available.
        /// </summary>
        /// <param name="address">HTLC address</param>
        /// <returns>HTLC secret</returns>
        public async Task<string> GetHtlcSeedAsync(string address)
        {
            return await _client.CallAsync<string>("spv_gethtlcseed", address);
        }

        /// <summary>
        /// Refunds all coins in HTLC address.
        /// Can be used after the timeout threshold set in createHtlc. See https://en.bitcoin.it/wiki/BIP_0199
        /// </summary>
        /// <param name="scriptAddress">HTLC address</param>
        /// <param name="destinationAddress">Destination for funds in the HTLC</param>
        /// <param name="feeRate">Fee rate in satoshis per KB. Minimum is 1000.</param>
        public async Task<SendMessageResult> RefundHtlcAsync(string scriptAddress, string destinationAddress, decimal feeRate = 10000)
        {
            return await _client.CallAsync<SendMessageResult>("spv_refundhtlc", scriptAddress, destinationAddress, feeRate);
        }

        /// <summary>
        /// List all outputs related to HTLC addresses in the wallet.
        /// </summary>
        /// <param name="scriptAddress">HTLC address to filter result</param>
        public async Task<ListHtlcsOutputsResult[]> ListHtlcOutputsAsync(string? scriptAddress = null)
        {
            return await _client.CallAsync<ListHtlcsOutputsResult[]>("spv_listhtlcoutputs", scriptAddress);
        }

        /// <summary>
        /// List anchor reward confirms
        /// </summary>
        public async Task<ListAnchorRewardConfirmationsResult[]> ListAnchorRewardConfirmationsAsync()
        {
            return await _client.CallAsync<ListAnchorRewardConfirmationsResult[]>("spv_listanchorrewardconfirms");
        }

        /// <summary>
        /// List unrewarded anchors
        /// </summary>
        public async Task<ListAnchorsResult[]> ListAnchorsUnrewardedAsync()
        {
            return await _client.CallAsync<ListAnchorsResult[]>("spv_listanchorsunrewarded");
        }

        /// <summary>
        /// List anchor rewards
        /// </summary>
        public async Task<ListAnchorRewardsResult[]> ListAnchorRewardsAsync()
        {
            return await _client.CallAsync<ListAnchorRewardsResult[]>("spv_listanchorrewards");
        }

        /// <summary>
        /// Create, sign and send anchor tx, using only SPV API
        /// </summary>
        /// <param name="createAnchorInputs">Info from BTC chain</param>
        /// <param name="rewardAddress">User's P2PKH address (in DeFi chain) for reward</param>
        /// <param name="options"></param>
        /// <returns></returns>
        public async Task<CreateAnchorResult> CreateAnchorAsync(CreateAnchorInput[] createAnchorInputs, string rewardAddress, CreateAnchorOptions? options = null)
        {
            options ??= new CreateAnchorOptions();
            return await _client.CallAsync<CreateAnchorResult>("spv_createanchor", createAnchorInputs, rewardAddress, options.Send, options.FeeRate);
        }

        /// <summary>
        /// List anchors
        /// </summary>
        public async Task<ListAnchorsResult> ListAnchorsAsync(ListAnchorsOptions? options = null)
        {
            options ??= new ListAnchorsOptions();
            return await _client.CallAsync<ListAnchorsResult>("spv_listanchors", options.MinBtcHeight, options.MaxBtcHeight, options.MinConfirmations, options.MaxConfirmations, options.StartBTCHeight, options.Limit);
        }

        /// <summary>
        /// List pending anchors in mempool
        /// </summary>
        public async Task<ListAnchorsResult[]> ListAnchorsPendingAsync()
        {
            return await _client.CallAsync<ListAnchorsResult[]>("spv_listanchorspending");
        }

        /// <summary>
        /// List anchor auths
        /// </summary>
        public async Task<ListAnchorAuthsResult[]> ListAnchorAuthsAsync()
        {
            return await _client.CallAsync<ListAnchorAuthsResult[]>("spv_listanchorauths");
        }

        /// <summary>
        /// Set last height on BTC chain, use for testing purpose
        /// </summary>
        public async Task SetLastHeightAsync(int height)
        {
            await _client.CallAsync("spv_setlastheight", height);
        }
    }
}