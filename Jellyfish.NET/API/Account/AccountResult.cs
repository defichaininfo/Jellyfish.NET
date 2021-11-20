namespace Jellyfish.API.Account;

public class AccountResult<TOwner, TAmount>
{
    public string Key { get; init; } = string.Empty;
    public TOwner? Owner { get; init; }
    public TAmount? Amount { get; init; }
}
