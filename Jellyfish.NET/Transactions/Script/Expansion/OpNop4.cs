namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop4 : StaticCode
{
    public OpNop4() : base(0xb3, "OP_NOP4") { }
}
