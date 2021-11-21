using System.Diagnostics;

namespace Jellyfish.Sample;

public class Program
{
    public static async Task Main()
    {
        var client = new JellyfishClient("http://foo:bar@localhost:8554");
        var prices = await client.Oracle.ListPricesAsync();
        
        foreach (var price in prices.Where(p => p.Ok))
        {
            Debug.WriteLine($"{price.Token}: {price.Price} {price.Currency}");
        }
    }
}