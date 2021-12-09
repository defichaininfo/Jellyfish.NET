namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 7 is pushed onto the stack.
/// </summary>
public class Op7 : StaticCode
{
    public Op7() : base(0x57, "OP_7") { }
}
