namespace Jellyfish.Transactions.Script.Splice;

/// <summary>
/// Concatenates two strings. disabled.
/// </summary>
public class OpCat : StaticCode
{
    public OpCat() : base(0x7e, "OP_CAT") { }
}
