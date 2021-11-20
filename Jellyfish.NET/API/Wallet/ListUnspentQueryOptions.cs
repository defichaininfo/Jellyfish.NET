namespace Jellyfish.API.Wallet;

public class ListUnspentQueryOptions
{
    /// <summary>
    /// default = 0, minimum value of each UTXO
    /// </summary>
    public decimal? MinimumAmount { get; init; } = 0;

    /// <summary>
    /// default is 'unlimited', maximum value of each UTXO
    /// </summary>
    public decimal? MaximumAmount { get; init; }

    /// <summary>
    /// default is 'unlimited', maximum number of UTXOs
    /// </summary>
    public int? MaximumCount { get; init; }

    /// <summary>
    /// default is 'unlimited', minimum sum valie of all UTXOs
    /// </summary>
    public decimal? MinimumSumAmount { get; init; }

    /// <summary>
    /// default is 'all', filter by token
    /// </summary>
    public string? TokenId { get; init; } = "all";
}
