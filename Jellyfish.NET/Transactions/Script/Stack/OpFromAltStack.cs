namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// Puts the input onto the top of the main stack. Removes it from the alt stack.
/// </summary>
public class OpFromAltStack : StaticCode
{
    public OpFromAltStack() : base(0x6c, "OP_FROMALTSTACK") { }
}
