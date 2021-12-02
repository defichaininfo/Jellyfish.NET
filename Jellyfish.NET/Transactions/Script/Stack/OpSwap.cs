namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The top two items on the stack are swapped.
/// </summary>
public class OpSwap : StaticCode
{
    public OpSwap() : base(0x7c, "OP_SWAP") { }
}