namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop5 : StaticCode
{
    public OpNop5() : base(0xb4, "OP_NOP5") { }
}
