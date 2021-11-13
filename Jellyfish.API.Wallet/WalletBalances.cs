namespace Jellyfish.API.Wallet;

public class WalletBalances
{
    public WalletMineBalances Mine { get; init; } = new WalletMineBalances();
    public WalletWatchOnlyBalances? WatchOnly { get; init; }
}
