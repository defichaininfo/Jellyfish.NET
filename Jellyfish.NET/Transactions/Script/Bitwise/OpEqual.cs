namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Returns 1 if the inputs are exactly equal, 0 otherwise.
/// </summary>
public class OpEqual : StaticCode
{
    public OpEqual() : base(0x87, "OP_EQUAL") { }
}
