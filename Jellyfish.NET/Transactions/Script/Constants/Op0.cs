namespace Jellyfish.Transactions.Script.Constants;

/// <summary>
/// An empty array of bytes is pushed onto the stack.
/// (This is not a no-op: an item is added to the stack.)
/// <see cref="OpFalse"/>
/// </summary>
public class Op0 : StaticCode
{
    public Op0() : base(0x00, "OP_0") { }
}
