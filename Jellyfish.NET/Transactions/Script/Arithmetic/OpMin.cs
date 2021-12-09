namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns the smaller of a and b.
/// </summary>
public class OpMin : StaticCode
{
    public OpMin() : base(0xa3, "OP_MIN") { }
}
