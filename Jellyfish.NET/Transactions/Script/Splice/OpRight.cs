namespace Jellyfish.Transactions.Script.Splice;

/// <summary>
/// Keeps only characters right of the specified point in a string. disabled.
/// </summary>
public class OpRight : StaticCode
{
    public OpRight() : base(0x81, "OP_RIGHT") { }
}
