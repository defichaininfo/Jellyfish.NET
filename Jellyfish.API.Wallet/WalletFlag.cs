namespace Jellyfish.API.Wallet;

public class WalletFlag
{
    private readonly string _value;

    public static WalletFlag AvoidReuse = new("avoid_reuse");

    private WalletFlag(string value)
    {
        _value = value;
    }

    public override string ToString()
    {
        return _value;
    }
}
