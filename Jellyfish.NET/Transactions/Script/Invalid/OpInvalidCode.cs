namespace Jellyfish.Transactions.Script.Invalid;

public class OpInvalidCode : StaticCode
{
    public OpInvalidCode() : base(0xff, "OP_INVALIDOPCODE") { }
}
