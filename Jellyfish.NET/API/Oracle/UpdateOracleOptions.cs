using Jellyfish.API.Core;

namespace Jellyfish.API.Oracle;

public class UpdateOracleOptions
{
    public OraclePriceFeed[]? PriceFeeds { get; init; }
    public double? Weightage { get; init; }
    public UTXO[] Utxos { get; init; } = Array.Empty<UTXO>();
}
