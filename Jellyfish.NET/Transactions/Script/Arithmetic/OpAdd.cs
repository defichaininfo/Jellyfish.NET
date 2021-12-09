namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// a is added to b.
/// </summary>
public class OpAdd : StaticCode
{
    public OpAdd() : base(0x93, "OP_ADD") { }
}
