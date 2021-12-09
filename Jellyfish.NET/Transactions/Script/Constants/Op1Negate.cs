namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number -1 is pushed onto the stack.
/// </summary>
public class Op1Negate : StaticCode
{
    public Op1Negate() : base(0x4f, "OP_1NEGATE") { }
}
