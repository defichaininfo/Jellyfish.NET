namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 9 is pushed onto the stack.
/// </summary>
public class Op9 : StaticCode
{
    public Op9() : base(0x59, "OP_9") { }
}
