namespace Jellyfish.Transactions;

/// <summary>
/// A transaction is a transfer of DeFi values that is broadcast to the DeFi network and collected into blocks.
/// The transfer of value in DeFi includes unspent, account token, liquidity, masternode creation, etc...
/// </summary>
public class Transaction
{
    public int Version { get; init; }
    public Vin[] Vin { get; init; } = Array.Empty<Vin>();
    public Vout[] Vout { get; init; } = Array.Empty<Vout>();
    public int LockTime { get; init; }
}
