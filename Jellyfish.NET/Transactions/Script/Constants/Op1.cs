namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 1 is pushed onto the stack.
/// <see cref="OpTrue"/>
/// </summary>
public class Op1 : StaticCode
{
    public Op1() : base(0x51, "OP_1") { }
}
