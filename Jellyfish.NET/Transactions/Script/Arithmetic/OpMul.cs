namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// a is multiplied by b. disabled.
/// </summary>
public class OpMul : StaticCode
{
    public OpMul() : base(0x95, "OP_MUL") { }
}
