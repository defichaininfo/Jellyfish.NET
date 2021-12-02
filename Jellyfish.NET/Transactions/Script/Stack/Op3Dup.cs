namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Duplicates the top three stack items.
/// </summary>
public class Op3Dup : StaticCode
{
    public Op3Dup() : base(0x6f, "OP_3DUP") { }
}
