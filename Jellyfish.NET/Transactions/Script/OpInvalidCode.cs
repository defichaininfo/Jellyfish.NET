namespace Jellyfish.Transactions.Script
{
    public class OpInvalidCode : StaticCode
    {
        public OpInvalidCode() : base(0xff, "OP_INVALIDOPCODE") { }
    }
}
