using Newtonsoft.Json;

namespace Jellyfish.API.SPV;

public class ListAnchorsOptions
{
    /// <summary>
    /// min BTC height
    /// </summary>
    public int? MinBtcHeight { get; init; } = -1;

    /// <summary>
    /// max BTC height
    /// </summary>
    public int? MaxBtcHeight { get; init; } = -1;

    /// <summary>
    /// min confirmations
    /// </summary>
    [JsonProperty("minConfs")]
    public int? MinConfirmations { get; init; } = -1;

    /// <summary>
    /// max confirmations
    /// </summary>
    [JsonProperty("maxConfs")]
    public int? MaxConfirmations { get; init; } = -1;
}
