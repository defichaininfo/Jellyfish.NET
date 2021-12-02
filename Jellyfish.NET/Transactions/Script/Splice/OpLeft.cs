namespace Jellyfish.Transactions.Script.Splice;

/// <summary>
/// Keeps only characters left of the specified point in a string. disabled.
/// </summary>
public class OpLeft : StaticCode
{
    public OpLeft() : base(0x80, "OP_LEFT") { }
}