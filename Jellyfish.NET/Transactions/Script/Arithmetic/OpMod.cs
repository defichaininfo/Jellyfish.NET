namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns the remainder after dividing a by b. disabled.
/// </summary>
public class OpMod : StaticCode
{
    public OpMod() : base(0x97, "OP_MOD") { }
}
