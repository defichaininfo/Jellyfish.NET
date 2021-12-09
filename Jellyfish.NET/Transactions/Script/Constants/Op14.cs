namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 14 is pushed onto the stack.
/// </summary>
public class Op14 : StaticCode
{
    public Op14() : base(0x5e, "OP_14") { }
}
