namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Copies the pair of items two spaces back in the stack to the front.
/// </summary>
public class Op2Over : StaticCode
{
    public Op2Over() : base(0x70, "OP_2OVER") { }
}
