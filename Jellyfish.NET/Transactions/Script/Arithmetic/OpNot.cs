namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// If the input is 0 or 1, it is flipped. Otherwise the output will be 0.
/// </summary>
public class OpNot : StaticCode
{
    public OpNot() : base(0x91, "OP_NOT") { }
}
