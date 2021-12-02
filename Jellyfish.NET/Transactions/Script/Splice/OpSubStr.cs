namespace Jellyfish.Transactions.Script.Splice;

/// <summary>
/// Returns a section of a string. disabled.
/// </summary>
public class OpSubStr : StaticCode
{
    public OpSubStr() : base(0x7f, "OP_SUBSTR") { }
}
