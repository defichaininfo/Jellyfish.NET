namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 6 is pushed onto the stack.
/// </summary>
public class Op6 : StaticCode
{
    public Op6() : base(0x56, "OP_6") { }
}
