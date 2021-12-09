namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if x is within the specified range (left-inclusive), 0 otherwise.
/// </summary>
public class OpWithin : StaticCode
{
    public OpWithin() : base(0xa5, "OP_WITHIN") { }
}
