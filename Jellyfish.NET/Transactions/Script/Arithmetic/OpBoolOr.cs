namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// If a or b is not 0, the output is 1. Otherwise 0.
/// </summary>
public class OpBoolOr : StaticCode
{
    public OpBoolOr() : base(0x9b, "OP_BOOLOR") { }
}
