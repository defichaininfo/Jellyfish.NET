namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Same as OP_EQUAL, but runs OP_VERIFY afterward.
/// </summary>
public class OpEqualVerify : StaticCode
{
    public OpEqualVerify() : base(0x88, "OP_EQUALVERIFY") { }
}
