using Jellyfish.API.Core;

namespace Jellyfish.API.Oracle;

public class SetOracleDataOptions
{
    public OraclePrice[]? Prices { get; init; }
    public UTXO[] Utxos { get; init; } = Array.Empty<UTXO>();
}
