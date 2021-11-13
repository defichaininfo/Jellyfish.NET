namespace Jellyfish.API.Governance;

public class CommunityFundRequest
{
    public string Title { get; init; } = string.Empty;
    public decimal Amount { get; init; }
    /// <summary>
    /// Any valid address to receive the funds
    /// </summary>
    public string PayoutAddress { get; init; } = string.Empty;
    /// <summary>
    /// Number of cycles for periodic fund request. Defaults to one cycle.
    /// </summary>
    public int Cycles { get; init; } = 1;
}
