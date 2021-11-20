using Jellyfish.API.Core;

namespace Jellyfish.API.Governance;

public class Governance
{
    private readonly IApiClient _client;

    public Governance(IApiClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a Community Fund Request.
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>txid</returns>
    public async Task<string> CreateCommunityFundRequestAsync(CommunityFundRequest request, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("createcfp", request, utxos);
    }

    /// <summary>
    /// Creates a Vote of Confidence.
    /// </summary>
    /// <param name="title">Vote of confidence's title</param>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>txid</returns>
    public async Task<string> CreateVoteOfConfidenceAsync(string title, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("createvoc", title, utxos);
    }

    /// <summary>
    /// Returns list of proposals.
    /// </summary>
    /// <param name="type">type of proposals</param>
    /// <param name="status">status of proposals</param>
    public async Task<Proposal[]> ListProposalsAsync(ListProposalType type = ListProposalType.All, ListProposalStatus status = ListProposalStatus.All)
    {
        return await _client.CallAsync<Proposal[]>("listproposals", type.ToString().ToLower(), status.ToString().ToLower());
    }

    /// <summary>
    /// Returns information about the proposal.
    /// </summary>
    public async Task<Proposal> GetProposalAsync(string proposalId)
    {
        return await _client.CallAsync<Proposal>("getproposal", proposalId);
    }

    /// <summary>
    /// Vote on a community proposal.
    /// </summary>
    /// <param name="utxos">Specific utxos to spend</param>
    /// <returns>txid</returns>
    public async Task<string> VoteAsync(Vote vote, UTXO[]? utxos = null)
    {
        utxos ??= Array.Empty<UTXO>();
        return await _client.CallAsync<string>("vote", vote.ProposalId, vote.MasternodeId, vote.Decision.ToString().ToLower(), utxos);
    }

    /// <summary>
    /// Returns information about proposal votes.
    /// </summary>
    public async Task<ListVotesResult[]> ListVotesAsync(string proposalId, string? masternode = null)
    {
        masternode ??= "mine";
        return await _client.CallAsync<ListVotesResult[]>("listvotes", proposalId, masternode);
    }

    /// <summary>
    /// Returns information about proposal votes.
    /// </summary>
    public async Task<ListVotesResult[]> ListVotesAsync(string proposalId, MasternodeType masternode)
    {
        return await _client.CallAsync<ListVotesResult[]>("listvotes", proposalId, masternode.ToString().ToLower());
    }
}
