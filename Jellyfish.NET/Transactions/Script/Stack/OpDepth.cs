namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Puts the number of stack items onto the stack.
/// </summary>
public class OpDepth : StaticCode
{
    public OpDepth() : base(0x74, "OP_DEPTH") { }
}
