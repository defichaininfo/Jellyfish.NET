namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 1 if the numbers are equal, 0 otherwise.
/// </summary>
public class OpNumEqual : StaticCode
{
    public OpNumEqual() : base(0x9c, "OP_NUMEQUAL") { }
}
