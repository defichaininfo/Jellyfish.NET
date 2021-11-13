using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.RawTransaction;

/// <summary>
/// RawTransaction RPCs for DeFi Blockchain
/// </summary>
public class RawTransaction
{
    private readonly IApiClient _client;

    public RawTransaction(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create a transaction spending the given inputs and creating new outputs that returns a hex-encoded raw transaction.
    /// Note that the transaction's inputs are not signed, and it is not stored in the wallet or transmitted to the network.
    /// </summary>
    /// <param name="inputs">array of inputs</param>
    /// <param name="outputs">array with outputs</param>
    /// <returns>hex string of the transaction</returns>
    public async Task<string> CreateRawTransactionAsync(CreateRawTxIn[] inputs, CreateRawTxOut outputs, CreateRawTxOptions? options = null)
    {
        options ??= new CreateRawTxOptions();
        return await _client.CallAsync<string>("createrawtransaction", inputs, outputs, options.LockTime, options.IsReplaceable);
    }

    /// <summary>
    /// Sign inputs for raw transaction (serialized, hex-encoded), providing an array of base58-encoded private keys that
    /// will be the keys used to sign the transaction. An optional array of previous transaction outputs that this
    /// transaction depends on but may not yet be in the blockchain.
    /// </summary>
    /// <param name="rawTransaction">unsigned raw transaction</param>
    /// <param name="privateKeys">array of base58-encoded private keys for signing (WIF)</param>
    /// <param name="options"></param>
    /// <returns></returns>
    public async Task<SignRawTxWithKeyResult> SignRawTransactionWithKeyAsync(string rawTransaction, string[] privateKeys, SignRawTxWithKeyOptions? options = null)
    {
        options ??= new SignRawTxWithKeyOptions();
        return await _client.CallAsync<SignRawTxWithKeyResult>("signrawtransactionwithkey", rawTransaction, privateKeys, options.PreviousTransactions, SignatureHashTypeToString(options.SignatureHashType));
    }

    private string SignatureHashTypeToString(SignatureHashType hashType)
    {
        return hashType switch
        {
            SignatureHashType.All => "ALL",
            SignatureHashType.None => "NONE",
            SignatureHashType.Single => "SINGLE",
            SignatureHashType.All_AnyoneCanPay => "ALL|ANYONECANPAY",
            SignatureHashType.None_AnyoneCanPay => "NONE|ANYONECANPAY",
            SignatureHashType.Single_AnyoneCanPay => "SINGLE|ANYONECANPAY",
            _ => "ALL",
        };
    }

    /// <summary>
    /// Returns result of mempool acceptance tests indicating if raw transaction would be accepted by mempool.
    /// This checks if the transaction violates the consensus or policy rules. The fee rate is expressed in DFI/kB,
    /// using the vSize of the transaction.
    /// </summary>
    /// <param name="signedTransaction">signed raw transaction</param>
    /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value. in DFI/kB</param>
    /// <returns>transaction mempool accept result</returns>
    public async Task<TestMempoolAcceptResult> TestMempoolAccentAsync(string signedTransaction, decimal maxFeeRate = 0)
    {
        var results = await _client.CallAsync<TestMempoolAcceptResult[]>("testmempoolaccept", new string[] { signedTransaction }, maxFeeRate);
        return results[0];
    }

    /// <summary>
    /// Submit a raw transaction (serialized, hex-encoded) to the connected node and network. The transaction will be sent
    /// unconditionally to all peers, so using this for manual rebroadcast may degrade privacy by leaking the transaction's
    /// origin, as nodes will normally not rebroadcast non-wallet transactions already in their mempool.
    /// </summary>
    /// <param name="signedTransaction">signed raw transaction</param>
    /// <param name="maxFeeRate">Reject transactions whose fee rate is higher than the specified value. in DFI/kB</param>
    /// <returns>transaction hash in hex</returns>
    public async Task<string> SendRawTransactionAsync(string signedTransaction, decimal maxFeeRate = 0)
    {
        return await _client.CallAsync<string>("sendrawtransaction", signedTransaction, maxFeeRate);
    }

    /// <summary>
    /// Get raw transaction in hex-encoded format
    /// </summary>
    /// <param name="transactionId">the transaction id</param>
    /// <param name="blockHash">the block hash</param>
    public async Task<string> GetRawTransactionAsync(uint256 transactionId, uint256? blockHash = null)
    {
        bool verbose = false;
        return await _client.CallAsync<string>("getrawtransaction", transactionId.ToString(), verbose, blockHash?.ToString());
    }

    /// <summary>
    /// Get raw transaction as json object
    /// </summary>
    /// <param name="transactionId">the transaction id</param>
    /// <param name="blockHash">the block hash</param>
    public async Task<RawTx> GetRawTransactionVerboseAsync(uint256 transactionId, uint256? blockHash = null)
    {
        bool verbose = true;
        return await _client.CallAsync<RawTx>("getrawtransaction", transactionId.ToString(), verbose, blockHash?.ToString());
    }
}
