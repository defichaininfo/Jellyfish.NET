namespace Jellyfish.Transactions;

public enum SigHash
{
    All = 0x01,
    None = 0x02,
    Single = 0x03,
    AnyoneCanPay = 0x80,
    All_AnyoneCanPay = All | AnyoneCanPay,
    None_AnyoneCanPay = None | AnyoneCanPay,
    Single_AnyoneCanPay = Single | AnyoneCanPay
}
