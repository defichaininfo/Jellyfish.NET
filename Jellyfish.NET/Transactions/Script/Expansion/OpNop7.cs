namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop7 : StaticCode
{
    public OpNop7() : base(0xb6, "OP_NOP7") { }
}
