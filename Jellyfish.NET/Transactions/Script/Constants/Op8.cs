namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 8 is pushed onto the stack.
/// </summary>
public class Op8 : StaticCode
{
    public Op8() : base(0x58, "OP_8") { }
}
