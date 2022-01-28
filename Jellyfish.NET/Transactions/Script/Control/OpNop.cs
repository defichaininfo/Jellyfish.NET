namespace Jellyfish.Transactions.Script.Control;

/// <summary>
/// Does nothing.
/// </summary>
public class OpNop : StaticCode
{
    public OpNop() : base(0x61, "OP_NOP") { }
}
