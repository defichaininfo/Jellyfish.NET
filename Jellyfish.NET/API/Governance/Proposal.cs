using Newtonsoft.Json;

namespace Jellyfish.API.Governance;

public class Proposal
{
    [JsonProperty("proposalId")]
    public string Id { get; init; } = string.Empty;
    public string Title { get; init; } = string.Empty;
    public ProposalType Type { get; init; }
    public ProposalStatus Status { get; init; }
    public decimal Amount { get; init; }
    public int CyclesPaid { get; init; }
    public int TotalCycles { get; init; }
    public uint FinalizeAfter { get; init; }
    public string PayoutAddress { get; init; } = string.Empty;
}
