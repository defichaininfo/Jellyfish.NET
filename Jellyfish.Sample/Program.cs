using System.Diagnostics;

namespace Jellyfish.Sample;

public class Program
{
    public static async Task Main()
    {
        var client = new JellyfishClient("http://foo:bar@localhost:8554");
        var auctions = await client.Loan.ListAuctionsAsync();
        var auctionHistory = await client.Loan.ListAuctionHistoryAsync("all");
        var info = await client.Loan.GetLoanInfoAsync();
    }
}