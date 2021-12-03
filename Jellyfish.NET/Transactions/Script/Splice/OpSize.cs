namespace Jellyfish.Transactions.Script.Splice;

/// <summary>
/// Pushes the string length of the top element of the stack (without popping it).
/// </summary>
public class OpSize : StaticCode
{
    public OpSize() : base(0x82, "OP_SIZE") { }
}