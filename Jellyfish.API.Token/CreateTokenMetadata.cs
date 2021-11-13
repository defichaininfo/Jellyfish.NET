using Newtonsoft.Json;

namespace Jellyfish.API.Token;

public class CreateTokenMetadata
{
    /// <summary>
    /// token's symbol (unique)
    /// </summary>
    public string Symbol { get; init; } = string.Empty;
    /// <summary>
    /// token's name (unique)
    /// </summary>
    public string Name { get; init; } = string.Empty;
    /// <summary>
    /// default = false
    /// </summary>
    public bool IsDAT { get; init; }
    /// <summary>
    /// default = true
    /// </summary>
    [JsonProperty("mintable")]
    public bool IsMintable { get; init; } = true;
    /// <summary>
    /// default = true
    /// </summary>
    [JsonProperty("tradeable")]
    public bool IsTradeable { get; init; } = true;
    /// <summary>
    /// for keeping collateral amount
    /// </summary>
    public string CollateralAddress { get; init; } = string.Empty;
}
