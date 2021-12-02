namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The item at the top of the stack is copied and inserted before the second-to-top item.
/// </summary>
public class OpTuck : StaticCode
{
    public OpTuck() : base(0x7d, "OP_TUCK") { }
}
