using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class SignRawTxWithKeyResult
{
    /// <summary>
    /// The hex-encoded raw transaction with signature(s)
    /// </summary>
    public string Hex { get; init; } = string.Empty;

    /// <summary>
    /// If the transaction has a complete set of signatures
    /// </summary>
    [JsonProperty("complete")]
    public bool IsComplete { get; init; }

    /// <summary>
    /// Script verification errors (if there are any)
    /// </summary>
    public SignRawTxWithKeyErrors[] Errors { get; init; } = Array.Empty<SignRawTxWithKeyErrors>();
}
