namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop6 : StaticCode
{
    public OpNop6() : base(0xb5, "OP_NOP6") { }
}
