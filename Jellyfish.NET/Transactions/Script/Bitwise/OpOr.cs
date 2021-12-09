namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Boolean OR between each bit in the inputs.
/// </summary>
public class OpOr : StaticCode
{
    public OpOr() : base(0x85, "OP_OR") { }
}
