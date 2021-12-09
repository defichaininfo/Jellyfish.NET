namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if a is greater than or equal to b, 0 otherwise.
/// </summary>
public class OpGreaterThanOrEqual : StaticCode
{
    public OpGreaterThanOrEqual() : base(0xa2, "OP_GREATERTHANOREQUAL") { }
}
