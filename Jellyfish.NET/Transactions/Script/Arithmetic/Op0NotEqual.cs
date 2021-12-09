namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Returns 0 if the input is 0. 1 otherwise.
/// </summary>
public class Op0NotEqual : StaticCode
{
    public Op0NotEqual() : base(0x92, "OP_0NOTEQUAL") { }
}
