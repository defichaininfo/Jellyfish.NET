namespace Jellyfish.API.Vault;

public class ListAuctionHistoryPagination
{
    /// <summary>
    /// Maximum block height
    /// </summary>
    public int? MaxBlockHeight { get; init; }

    /// <summary>
    /// Vault Id
    /// </summary>
    public string? VaultId { get; init; }

    /// <summary>
    /// Auction index
    /// </summary>
    public int? Index { get; init; }

    public int? Limit { get; init; } = 100;
}
