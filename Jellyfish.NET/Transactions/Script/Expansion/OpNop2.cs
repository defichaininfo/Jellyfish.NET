namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction allows a transaction output to be made unspendable until some point in the future.
/// See <see cref="OpCheckLockTimeVerify"/>.
/// </summary>
public class OpNop2 : OpCheckLockTimeVerify
{

}
