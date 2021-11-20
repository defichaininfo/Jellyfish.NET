namespace Jellyfish.API.Account;

public static class DfTxType
{
    public const string MintToken = "M";
    public const string PoolSwap = "S";
    public const string AddPoolLiquidity = "l";
    public const string RemovePoolLiquidity = "r";
    public const string UtxosToAccount = "U";
    public const string AccountToUtxos = "b";
    public const string AccountToAccount = "B";
    public const string AnyAccountsToAccounts = "a";
    public const string CreateMasternode = "C";
    public const string ResignMasternode = "R";
    public const string CreateToken = "T";
    public const string UpdateToken = "N";
    public const string UpdateTokenAny = "n";
    public const string CreatePoolPair = "p";
    public const string UpdatePoolPair = "u";
    public const string SetGovVariable = "G";
    public const string AutoAuthPrep = "A";
    public const string None = "0";
}
