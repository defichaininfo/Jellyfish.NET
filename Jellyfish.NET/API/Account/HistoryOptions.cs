using Newtonsoft.Json;

namespace Jellyfish.API.Account;

public abstract class HistoryOptions
{
    /// <summary>
    /// Optional height to iterate from (down to genesis block), (default = chaintip).
    /// </summary>
    public int? MaxBlockHeight { get; init; }

    /// <summary>
    /// Maximum depth, from the genesis block is the default
    /// </summary>
    public int? Depth { get; init; }

    /// <summary>
    /// Filter by token
    /// </summary>
    public string? Token { get; init; }

    /// <summary>
    /// Filter by transaction type. See <see cref="DfTxType"/>.
    /// </summary>
    [JsonProperty("txtype")]
    public string? TransactionType { get; init; }

    /// <summary>
    /// Maximum number of records to return, 100 by default
    /// </summary>
    public int? Limit { get; init; } = 100;

    /// <summary>
    /// Order in block, unlimited by default
    /// </summary>
    public decimal? Txn { get; init; }
}
