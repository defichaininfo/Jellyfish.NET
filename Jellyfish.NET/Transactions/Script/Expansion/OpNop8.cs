namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction performs no operation.
/// No items are added to the stack.
/// </summary>
public class OpNop8 : StaticCode
{
    public OpNop8() : base(0xb7, "OP_NOP8") { }
}
