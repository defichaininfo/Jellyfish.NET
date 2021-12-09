namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Boolean AND between each bit in the inputs.
/// </summary>
public class OpAnd : StaticCode
{
    public OpAnd() : base(0x84, "OP_AND") { }
}
