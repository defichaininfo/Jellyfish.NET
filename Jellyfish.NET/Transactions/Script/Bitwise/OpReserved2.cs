namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Transaction is invalid unless occuring in an unexecuted OP_IF branch.
/// </summary>
public class OpReserved2 : StaticCode
{
    public OpReserved2() : base(0x8a, "OP_RESERVED2") { }
}
