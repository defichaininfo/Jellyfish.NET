namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop10 : StaticCode
{
    public OpNop10() : base(0xb9, "OP_NOP10") { }
}
