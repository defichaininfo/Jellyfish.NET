namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 16 is pushed onto the stack.
/// </summary>
public class Op16 : StaticCode
{
    public Op16() : base(0x60, "OP_16") { }
}
