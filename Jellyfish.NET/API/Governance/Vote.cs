namespace Jellyfish.API.Governance;

public class Vote
{
    public string ProposalId { get; init; } = string.Empty;
    public string MasternodeId { get; init; } = string.Empty;
    public VoteDecision Decision { get; }
}
