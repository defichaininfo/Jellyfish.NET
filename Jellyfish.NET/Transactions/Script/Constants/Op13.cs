namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 13 is pushed onto the stack.
/// </summary>
public class Op13 : StaticCode
{
    public Op13() : base(0x5d, "OP_13") { }
}
