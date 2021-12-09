namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Transaction is invalid unless occuring in an unexecuted OP_IF branch.
/// </summary>
public class OpReserved1 : StaticCode
{
    public OpReserved1() : base(0x89, "OP_RESERVED1") { }
}
