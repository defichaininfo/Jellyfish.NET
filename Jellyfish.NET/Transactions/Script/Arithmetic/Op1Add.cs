namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// 1 is added to the input.
/// </summary>
public class Op1Add : StaticCode
{
    public Op1Add() : base(0x8b, "OP_1ADD") { }
}
