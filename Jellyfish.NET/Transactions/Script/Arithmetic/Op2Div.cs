namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// The input is divided by 2. disabled.
/// </summary>
public class Op2Div : StaticCode
{
    public Op2Div() : base(0x8e, "OP_2DIV") { }
}
