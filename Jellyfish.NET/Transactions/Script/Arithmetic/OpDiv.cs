namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// a is divided by b. disabled.
/// </summary>
public class OpDiv : StaticCode
{
    public OpDiv() : base(0x96, "OP_DIV") { }
}
