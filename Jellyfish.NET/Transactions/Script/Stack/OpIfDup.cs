namespace Jellyfish.Transactions.Script.Stack;

/// <summary>
/// If the top stack value is not 0, duplicate it.
/// </summary>
public class OpIfDup : StaticCode
{
    public OpIfDup() : base(0x73, "OP_IFDUP") { }
}
