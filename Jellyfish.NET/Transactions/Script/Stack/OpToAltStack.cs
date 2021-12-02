namespace Jellyfish.Transactions.Script;

/// <summary>
/// Puts the input onto the top of the alt stack. Removes it from the main stack.
/// </summary>
public class OpToAltStack : StaticCode
{
    public OpToAltStack() : base(0x6b, "OP_TOALTSTACK") { }
}
