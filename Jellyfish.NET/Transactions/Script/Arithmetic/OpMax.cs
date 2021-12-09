namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns the larger of a and b.
/// </summary>
public class OpMax : StaticCode
{
    public OpMax() : base(0xa4, "OP_MAX") { }
}
