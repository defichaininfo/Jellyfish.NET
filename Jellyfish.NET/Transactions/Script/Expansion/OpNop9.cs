namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop9 : StaticCode
{
    public OpNop9() : base(0xb8, "OP_NOP9") { }
}
