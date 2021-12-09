namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 2 is pushed onto the stack.
/// </summary>
public class Op2 : StaticCode
{
    public Op2() : base(0x52, "OP_2") { }
}
