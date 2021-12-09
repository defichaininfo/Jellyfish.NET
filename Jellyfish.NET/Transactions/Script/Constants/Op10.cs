namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 10 is pushed onto the stack.
/// </summary>
public class Op10 : StaticCode
{
    public Op10() : base(0x5a, "OP_10") { }
}
