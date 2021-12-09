namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// The input is made positive.
/// </summary>
public class OpAbs : StaticCode
{
    public OpAbs() : base(0x8f, "OP_ABS") { }
}
