namespace Jellyfish.API.Loan;

public class PlaceAuctionBid
{
    /// <summary>
    /// Vault Id
    /// </summary>
    public string VaultId { get; init; } = string.Empty;

    /// <summary>
    /// Auction index
    /// </summary>
    public double Index { get; init; }

    /// <summary>
    /// Address to get token
    /// </summary>
    public string From { get; init; } = string.Empty;

    /// <summary>
    /// in "amount@symbol" format
    /// </summary>
    public string Amount { get; init; } = string.Empty;
}
