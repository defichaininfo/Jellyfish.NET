using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ReceivedByAddressInfo
{
    /// <summary>
    /// Recieving address
    /// </summary>
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// Address type
    /// </summary>
    public string Type { get; init; } = string.Empty;

    /// <summary>
    /// Total amount of BTC recieved by the address
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// The number of confirmations
    /// </summary>
    public int Confirmations { get; init; }

    /// <summary>
    /// The ids of transactions received by the address
    /// </summary>
    [JsonProperty("txids")]
    public string[] TransactionIds { get; init; } = Array.Empty<string>();
}
