namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The item n back in the stack is moved to the top.
/// </summary>
public class OpRoll : StaticCode
{
    public OpRoll() : base(0x7a, "OP_ROLL") { }
}
