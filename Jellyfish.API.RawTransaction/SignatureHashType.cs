namespace Jellyfish.API.RawTransaction;

public enum SignatureHashType
{
    All,
    None,
    Single,
    All_AnyoneCanPay,
    None_AnyoneCanPay,
    Single_AnyoneCanPay
}
