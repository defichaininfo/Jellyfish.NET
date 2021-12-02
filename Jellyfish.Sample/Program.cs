using System.Diagnostics;

namespace Jellyfish.Sample;

public class Program
{
    public static async Task Main()
    {
        var client = new JellyfishClient("http://foo:bar@localhost:8554");
        var info = await client.Blockchain.GetBlockchainInfoAsync();
        var proposals = await client.Governance.ListProposalsAsync(API.Governance.ListProposalType.Cfp, API.Governance.ListProposalStatus.Voting);
    }
}