using Newtonsoft.Json;

namespace Jellyfish.API.Core;

public class UTXO
{
    [JsonProperty("txid")]
    public string TransactionId { get; init; } = string.Empty;
    /// <summary>
    /// output number
    /// </summary>
    public uint Vout { get; init; }
}
