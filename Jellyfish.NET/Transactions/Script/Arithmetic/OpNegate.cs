namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// The sign of the input is flipped.
/// </summary>
public class OpNegate : StaticCode
{
    public OpNegate() : base(0x8f, "OP_NEGATE") { }
}
