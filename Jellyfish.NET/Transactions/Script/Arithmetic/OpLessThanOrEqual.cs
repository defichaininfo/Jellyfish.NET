namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if a is less than or equal to b, 0 otherwise.
/// </summary>
public class OpLessThanOrEqual : StaticCode
{
    public OpLessThanOrEqual() : base(0xa1, "OP_LESSTHANOREQUAL") { }
}
