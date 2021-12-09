namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 5 is pushed onto the stack.
/// </summary>
public class Op5 : StaticCode
{
    public Op5() : base(0x55, "OP_5") { }
}
