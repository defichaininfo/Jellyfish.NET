namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 15 is pushed onto the stack.
/// </summary>
public class Op15 : StaticCode
{
    public Op15() : base(0x5f, "OP_15") { }
}
