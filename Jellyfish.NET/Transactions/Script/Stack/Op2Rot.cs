namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The fifth and sixth items back are moved to the top of the stack.
/// </summary>
public class Op2Rot : StaticCode
{
    public Op2Rot() : base(0x71, "OP_2ROT") { }
}
