using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class SignRawTxWithKeyOptions
{
    /// <summary>
    /// array of previous dependent transaction outputs
    /// </summary>
    [JsonProperty("prevTxs")]
    public SignRawTxWithKeyPrevTx[]? PreviousTransactions { get; init; } = Array.Empty<SignRawTxWithKeyPrevTx>();

    /// <summary>
    /// the signature hash type to use
    /// </summary>
    [JsonProperty("sigHashType")]
    public SignatureHashType SignatureHashType { get; init; } = SignatureHashType.All;
}
