namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Shifts a right b bits, preserving sign. disabled.
/// </summary>
public class OpRShift : StaticCode
{
    public OpRShift() : base(0x99, "OP_RSHIFT") { }
}
