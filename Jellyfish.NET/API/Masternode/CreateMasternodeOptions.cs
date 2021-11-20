using Jellyfish.API.Core;

namespace Jellyfish.API.Masternode;

public class CreateMasternodeOptions
{
    public UTXO[] Utxos { get; init; } = Array.Empty<UTXO>();
    /// <summary>
    /// specify a fix period (5 or 10 years) lock which cannot be resigned and cannot spend the collateral
    /// </summary>
    public MasternodeTimeLock? TimeLock { get; init; }
}
