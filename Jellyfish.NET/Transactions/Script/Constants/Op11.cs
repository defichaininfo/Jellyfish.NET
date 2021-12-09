namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 11 is pushed onto the stack.
/// </summary>
public class Op11 : StaticCode
{
    public Op11() : base(0x5b, "OP_11") { }
}
