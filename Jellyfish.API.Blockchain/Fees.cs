namespace Jellyfish.API.Blockchain;

public class Fees
{
    public decimal Base { get; init; }
    public decimal Modified { get; init; }
    public decimal Ancestor { get; init; }
    public decimal Descendant { get; init; }
}
