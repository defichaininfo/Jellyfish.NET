using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class CreateRawTxIn
{
    [JsonProperty("txid")]
    public string TransactionId { get; init; } = string.Empty;
    public uint Vout { get; init; }
    public int? Sequence { get; init; }
}
