namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 4 is pushed onto the stack.
/// </summary>
public class Op4 : StaticCode
{
    public Op4() : base(0x54, "OP_4") { }
}
