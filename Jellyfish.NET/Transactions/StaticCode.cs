namespace Jellyfish.Transactions;

/// <summary>
/// Statically mapped code of OPCode
/// </summary>
public class StaticCode : OPCode
{
    public int Code { get; }

    public StaticCode(int code, string type) : base(type)
    {
        Code = code;
    }
}
