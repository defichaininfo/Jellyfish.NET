namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Copies the second-to-top stack item to the top.
/// </summary>
public class OpOver : StaticCode
{
    public OpOver() : base(0x78, "OP_OVER") { }
}
