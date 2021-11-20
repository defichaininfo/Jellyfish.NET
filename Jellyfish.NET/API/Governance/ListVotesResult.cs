namespace Jellyfish.API.Governance;

public class ListVotesResult
{
    public string ProposalId { get; init; } = string.Empty;
    public string MasternodeId { get; init; } = string.Empty;
    public int Cycle { get; init; }
    public string Vote { get; init; } = string.Empty;
}
