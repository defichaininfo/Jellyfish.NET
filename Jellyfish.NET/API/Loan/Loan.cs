using Jellyfish.API.Core;
using NBitcoin;

namespace Jellyfish.API.Loan;

/// <summary>
/// Loan RPCs for DeFi Blockchain
/// </summary>
public class Loan
{
    private readonly IApiClient _client;

    public Loan(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a loan scheme transaction.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>LoanSchemeId, also the txn id for txn created to create loan scheme</returns>
    public async Task<string> CreateLoanSchemeAsync(CreateLoanScheme scheme, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("createloanscheme", scheme.MinimumCollateralizationRatio, scheme.InterestRate, scheme.Id, utxos);
    }

    /// <summary>
    /// Updates an existing loan scheme.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>Hex string of the transaction</returns>
    public async Task<string> UpdateLoanSchemeAsync(UpdateLoanScheme scheme, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("updateloanscheme", scheme.MinimumCollateralizationRatio, scheme.InterestRate, scheme.Id, scheme.ActivateAfterBlock, utxos);
    }

    /// <summary>
    /// Destroys a loan scheme.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>Hex string of the transaction</returns>
    public async Task<string> DestroyLoanScheme(DestroyLoanScheme scheme, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("destroyloanscheme", scheme.Id, scheme.ActivateAfterBlock, utxos);
    }

    /// <summary>
    /// List all available loan schemes.
    /// </summary>
    public async Task<LoanSchemeResult[]> ListLoanSchemesAsync()
    {
        return await _client.CallAsync<LoanSchemeResult[]>("listloanschemes");
    }

    /// <summary>
    /// Get loan scheme.
    /// </summary>
    /// <param name="id">Unique identifier of the loan scheme, max 8 chars.</param>
    public async Task<GetLoanSchemeResult> GetLoanSchemeAsync(string id)
    {
        return await _client.CallAsync<GetLoanSchemeResult>("getloanscheme", id);
    }

    /// <summary>
    /// Sets the default loan scheme.
    /// </summary>
    /// <param name="id">Unique identifier of the loan scheme, max 8 chars</param>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>Hex string of the transaction</returns>
    public async Task<string> SetDefaultLoanSchemeAsync(string id, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("setdefaultloanscheme", id, utxos);
    }

    /// <summary>
    /// Set a collateral token transaction.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>collateralTokenId, also the txn id for txn created to set collateral token</returns>
    public async Task<string> SetCollateralTokenAsync(SetCollateralToken collateralToken, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("setcollateraltoken", collateralToken, utxos);
    }

    /// <summary>
    /// List collateral tokens.
    /// </summary>
    /// <returns>Get all collateral tokens</returns>
    public async Task<CollateralTokenDetail[]> ListCollateralTokensAsync(ListCollateralTokens? collateralTokens = null)
    {
        collateralTokens ??= new ListCollateralTokens();
        return await _client.CallAsync<CollateralTokenDetail[]>("listcollateraltokens", collateralTokens);
    }

    /// <summary>
    /// Get collateral token.
    /// </summary>
    /// <param name="token">token symbol or id</param>
    /// <returns>Collateral token result</returns>
    public async Task<CollateralTokenDetail> GetCollateralTokenAsync(string token)
    {
        return await _client.CallAsync<CollateralTokenDetail>("getcollateraltoken", token);
    }

    /// <summary>
    /// Creates (and submits to local node and network) a token for a price feed set in collateral token.
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>LoanTokenId, also the txn id for txn created to set loan token</returns>
    public async Task<string> SetLoanTokenAsync(SetLoanToken loanToken, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("setloantoken", loanToken, utxos);
    }

    /// <summary>
    /// Updates an existing loan token.
    /// </summary>
    /// <param name="oldToken">Previous tokens's symbol, id or creation tx (unique)</param>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>LoanTokenId, also the txn id for txn created to update loan token</returns>
    public async Task<string> UpdateLoanTokenAsync(string oldToken, UpdateLoanToken newTokenDetails, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("updateloantoken", oldToken, newTokenDetails, utxos);
    }

    /// <summary>
    /// Get interest info
    /// </summary>
    /// <param name="id">Loan scheme id</param>
    /// <param name="token">Specified by loan token id, loan token name and loan toekn creation tx</param>
    public async Task<Interest[]> GetInterestAsync(string id, string? token = null)
    {
        return await _client.CallAsync<Interest[]>("getinterest", id, token);
    }

    /// <summary>
    /// Get loan token.
    /// </summary>
    /// <param name="token">Symbol or id of loan token</param>
    /// <returns>Loan token details</returns>
    public async Task<LoanTokenResult> GetLoanTokenAsync(string token)
    {
        return await _client.CallAsync<LoanTokenResult>("getloantoken", token);
    }

    /// <summary>
    /// List all created loan tokens.
    /// </summary>
    public async Task<LoanTokenResult[]> ListLoanTokensAsync()
    {
        return await _client.CallAsync<LoanTokenResult[]>("listloantokens");
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
    /// Take loan
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    public async Task<string> TakeLoanAsync(TakeLoanMetadata metadata, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("takeloan", metadata, utxos);
    }

    /// <summary>
    /// Return loan in a desired amount.
    /// </summary>
    public async Task<string> PaybackLoanAsync(PaybackLoanMetadata metadata, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("paybackloan", metadata, utxos);
    }

    /// <summary>
    /// Bid to vault in auction
    /// </summary>
    /// <param name="utxos">Specific UTXOs to spend</param>
    /// <returns>The transaction id</returns>
    public async Task<string> PlaceAuctionBidAsync(AuctionBid placeAuctionBid, UTXO[]? utxos = null)
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
}
