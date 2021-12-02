namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The 3rd item down the stack is moved to the top.
/// </summary>
public class OpRot : StaticCode
{
    public OpRot() : base(0x7b, "OP_ROT") { }
}
