namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// The number 3 is pushed onto the stack.
/// </summary>
public class Op3 : StaticCode
{
    public Op3() : base(0x53, "OP_3") { }
}
