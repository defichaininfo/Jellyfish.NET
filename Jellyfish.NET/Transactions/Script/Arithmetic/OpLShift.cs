namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Shifts a left b bits, preserving sign. disabled.
/// </summary>
public class OpLShift : StaticCode
{
    public OpLShift() : base(0x98, "OP_LSHIFT") { }
}
