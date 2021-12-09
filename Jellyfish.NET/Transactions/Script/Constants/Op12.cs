namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 12 is pushed onto the stack.
/// </summary>
public class Op12 : StaticCode
{
    public Op12() : base(0x5c, "OP_12") { }
}
