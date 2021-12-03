namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction allows a transaction output to be made unspendable until some point in the future.
/// </summary>
public class OpCheckLockTimeVerify : StaticCode
{
    public OpCheckLockTimeVerify() : base(0xb1, "OP_CHECKLOCKTIMEVERIFY") { }
}
