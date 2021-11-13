using System.Threading.Tasks;

namespace Jellyfish.Sample;

public class Program
{
    public static async Task Main()
    {
        var client = new JellyfishClient("http://foo:bar@localhost:8554");
        var walletInfo = await client.Governance.ListProposalsAsync();
    }
}
