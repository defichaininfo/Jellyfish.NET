namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Removes the second-to-top stack item.
/// </summary>
public class OpNip : StaticCode
{
    public OpNip() : base(0x77, "OP_NIP") { }
}
