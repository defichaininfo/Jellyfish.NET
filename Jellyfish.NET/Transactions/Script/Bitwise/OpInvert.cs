namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Flips all of the bits in the input.
/// </summary>
public class OpInvert : StaticCode
{
    public OpInvert() : base(0x83, "OP_INVERT") { }
}
