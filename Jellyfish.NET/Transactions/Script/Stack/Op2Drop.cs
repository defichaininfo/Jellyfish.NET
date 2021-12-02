namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Removes the top two stack items.
/// </summary>
public class Op2Drop : StaticCode
{
    public Op2Drop() : base(0x6d, "OP_2DROP") { }
}
