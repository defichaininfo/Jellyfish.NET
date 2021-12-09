namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// If both a and b are not 0, the output is 1. Otherwise 0.
/// </summary>
public class OpBoolAnd : StaticCode
{
    public OpBoolAnd() : base(0x9a, "OP_BOOLAND") { }
}
