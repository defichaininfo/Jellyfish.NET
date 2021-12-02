namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Duplicates the top stack item.
/// </summary>
public class OpDup : StaticCode
{
    public OpDup() : base(0x76, "OP_DUP") { }
}
