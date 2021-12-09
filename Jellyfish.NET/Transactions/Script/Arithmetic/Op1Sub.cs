namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// 1 is subtracted from the input.
/// </summary>
public class Op1Sub : StaticCode
{
    public Op1Sub() : base(0x8c, "OP_1SUB") { }
}
