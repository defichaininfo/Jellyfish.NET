namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// The item n back in the stack is copied to the top.
/// </summary>
public class OpPick : StaticCode
{
    public OpPick() : base(0x79, "OP_PICK") { }
}
