namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Removes the top stack item.
/// </summary>
public class OpDrop : StaticCode
{
    public OpDrop() : base(0x75, "OP_DROP") { }
}