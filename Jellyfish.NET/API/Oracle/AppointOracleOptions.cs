using Jellyfish.API.Core;

namespace Jellyfish.API.Oracle;

public class AppointOracleOptions
{
    public double? Weightage { get; init; }
    public UTXO[] Utxos { get; init; } = Array.Empty<UTXO>();
}
