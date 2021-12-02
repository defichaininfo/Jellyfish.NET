namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Swaps the top two pairs of items.
/// </summary>
public class Op2Swap : StaticCode
{
    public Op2Swap() : base(0x72, "OP_2SWAP") { }
}
