namespace Jellyfish.Transactions.Script.Bitwise;

/// <summary>
/// Boolean exclusive OR between each bit in the inputs.
/// </summary>
public class OpXor : StaticCode
{
    public OpXor() : base(0x86, "OP_XOR") { }
}
