namespace Jellyfish.Transactions.Script.Arithmetic;

/// <summary>
/// Same as OP_NUMEQUAL, but runs OP_VERIFY afterward.
/// </summary>
public class OpNumEqualVerify : StaticCode
{
    public OpNumEqualVerify() : base(0x9d, "OP_NUMEQUALVERIFY") { }
}
