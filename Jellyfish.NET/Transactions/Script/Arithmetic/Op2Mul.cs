namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// The input is multiplied by 2. disabled.
/// </summary>
public class Op2Mul : StaticCode
{
    public Op2Mul() : base(0x8d, "OP_2MUL") { }
}
