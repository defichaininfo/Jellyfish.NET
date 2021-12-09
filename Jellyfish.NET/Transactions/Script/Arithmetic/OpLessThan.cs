namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if a is less than b, 0 otherwise.
/// </summary>
public class OpLessThan : StaticCode
{
    public OpLessThan() : base(0x9f, "OP_LESSTHAN") { }
}
