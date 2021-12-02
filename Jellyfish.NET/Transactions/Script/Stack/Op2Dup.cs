namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Duplicates the top two stack items.
/// </summary>
public class Op2Dup : StaticCode
{
    public Op2Dup() : base(0x6e, "OP_2DUP") { }
}
