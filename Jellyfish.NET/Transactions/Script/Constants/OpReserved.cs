namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// Transaction is invalid unless occuring in an unexecuted OP_IF branch.
/// </summary>
public class OpReserved : StaticCode
{
    public OpReserved() : base(0x50, "OP_RESERVED") { }
}
