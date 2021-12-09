namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if a is greater than b, 0 otherwise.
/// </summary>
public class OpGreaterThan : StaticCode
{
    public OpGreaterThan() : base(0xa0, "OP_GREATERTHAN") { }
}
