namespace Jellyfish.API.Wallet;

public class WalletMineBalances : WalletWatchOnlyBalances
{
    public decimal? Used { get; init; }
}
