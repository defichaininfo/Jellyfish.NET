namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// b is subtracted from a.
/// </summary>
public class OpSub : StaticCode
{
    public OpSub() : base(0x94, "OP_SUB") { }
}
