namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if the numbers are not equal, 0 otherwise.
/// </summary>
public class OpNumNotEqual : StaticCode
{
    public OpNumNotEqual() : base(0x9e, "OP_NUMNOTEQUAL") { }
}
