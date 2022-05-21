using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.Vault;

public class Vault
{
    private readonly IApiClient _client;

    public Vault(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a vault transaction.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>Transaction id of the transaction</returns>
    public async Task<uint256> CreateVaultAsync(CreateVault vault, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        var txid = await _client.CallAsync<string>("createvault", vault.OwnerAddress, vault.LoanSchemeId, utxos);
        return uint256.Parse(txid);
    }

    /// <summary>
    /// Create update vault transaction.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>Transaction id of the transaction</returns>
    public async Task<string> UpdateVaultAsync(string vaultId, UpdateVault vault, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("updatevault", vaultId, vault, utxos);
    }

    /// <summary>
    /// Returns information about vault.
    /// </summary>
    /// <param name="vaultId">vault hex id</param>
    public async Task<Vault> GetVaultAsync(string vaultId)
    {
        return await _client.CallAsync<Vault>("getvault", vaultId);
    }

    /// <summary>
    /// List all available vaults.
    /// </summary>
    /// <returns>Array of objects including details of the vaults.</returns>
    public async Task<Vault[]> ListVaultsAsync(VaultPagination? pagination = null, ListVaultOptions? options = null)
    {
        pagination ??= new VaultPagination();
        options ??= new ListVaultOptions();
        return await _client.CallAsync<Vault[]>("listvaults", options, pagination);
    }

    /// <summary>
    /// Close vault
    /// </summary>
    public async Task<string> CloseVaultAsync(CloseVault closeVault, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("closevault", closeVault.VaultId, closeVault.To, utxos);
    }

    /// <summary>
    /// Deposit to vault
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    public async Task<string> DepositToVaultAsync(DepositVault depositVault, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("deposittovault", depositVault.VaultId, depositVault.From, depositVault.Amount, utxos);
    }

    /// <summary>
    /// Withdraw from vault
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    public async Task<string> WithdrawFromVault(WithdrawVault withdrawVault, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("withdrawfromvault", withdrawVault.VaultId, withdrawVault.To, withdrawVault.Amount, utxos);
    }

    /// <summary>
    /// Bid to vault in auction
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>The transaction id</returns>
    public async Task<string> PlaceAuctionBidAsync(PlaceAuctionBid placeAuctionBid, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("placeauctionbid", placeAuctionBid.VaultId, placeAuctionBid.Index, placeAuctionBid.From, placeAuctionBid.Amount, utxos);
    }

    /// <summary>
    /// List all available auctions.
    /// </summary>
    public async Task<VaultLiquidation[]> ListAuctionsAsync(AuctionPagination? pagination = null)
    {
        pagination ??= new AuctionPagination();
        return await _client.CallAsync<VaultLiquidation[]>("listauctions", pagination);
    }

    /// <summary>
    /// Returns information about auction history.
    /// </summary>
    /// <param name="owner">address or reserved word : mine / all (Default to mine)</param>
    public async Task<ListAuctionHistoryDetail[]> ListAuctionHistoryAsync(string owner = "mine", ListAuctionHistoryPagination? pagination = null)
    {
        pagination ??= new ListAuctionHistoryPagination();
        return await _client.CallAsync<ListAuctionHistoryDetail[]>("listauctionhistory", owner, pagination);
    }

    /// <summary>
    /// Returns amount of collateral tokens needed to take an amount of loan tokens for a target collateral ratio.
    /// </summary>
    /// <param name="loanAmounts">Amount as array. Example: [ "amount@token" ]</param>
    /// <param name="targetRatio">Target collateral ratio.</param>
    /// <param name="tokenSplit">Object with loans token as key and their percent split as value</param>
    /// <returns>Array of <amount@token> strings</returns>
    public async Task<string[]> EstimateCollateralAsync(string[] loanAmounts, decimal targetRatio, TokenPercentageSplit? tokenSplit)
    {
        tokenSplit ??= new TokenPercentageSplit { { "DFI", 1 } };
        return await _client.CallAsync<string[]>("estimatecollateral", loanAmounts, targetRatio, tokenSplit);
    }

    /// <summary>
    /// Returns amount of loan tokens a vault can take depending on a target collateral ratio.
    /// </summary>
    /// <param name="vaultId">vault hex id</param>
    /// <param name="tokenSplit">Object with loans token as key and their percent split as value</param>
    /// <param name="targetRatio">Target collateral ratio. (defaults to vault's loan scheme ratio)</param>
    /// <returns>Array of `token@amount`</returns>
    public async Task<string[]> EstimateLoanAsync(string vaultId, TokenPercentageSplit tokenSplit, decimal? targetRatio)
    {
        if (targetRatio == null)
        {
            return await _client.CallAsync<string[]>("estimateloan", vaultId, tokenSplit);
        }
        else
        {
            return await _client.CallAsync<string[]>("estimateloan", vaultId, tokenSplit, targetRatio);
        }
    }

    /// <summary>
    /// Returns estimated vault for given collateral and loan amounts.
    /// </summary>
    /// <param name="collateralAmounts">Collateral amounts as string array. [ "amount@token" ]</param>
    /// <param name="loanAmounts">Loan amounts as string array. [ "amount@token" ]</param>
    public async Task<VaultEstimation> EstimateVaultAsync(string[] collateralAmounts, string[] loanAmounts)
    {
        return await _client.CallAsync<VaultEstimation>("estimatevault", collateralAmounts, loanAmounts);
    }
}
