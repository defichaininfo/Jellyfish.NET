namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation. No items are added to the stack.
/// </summary>
public class OpNop1 : StaticCode
{
    public OpNop1() : base(0xb0, "OP_NOP1") { }
}