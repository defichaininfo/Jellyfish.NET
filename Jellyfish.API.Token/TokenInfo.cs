using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Token;

public class TokenInfo
{
    public string Symbol { get; init; } = string.Empty;
    public string SymbolKey { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public decimal Decimal { get; init; }
    public decimal Limit { get; init; }
    [JsonProperty("mintable")]
    public bool IsMintable { get; init; }
    [JsonProperty("tradeable")]
    public bool IsTradeable { get; init; }
    public bool IsDAT { get; init; }
    public bool IsLPS { get; init; }
    public bool IsLoanToken { get; init; }
    [JsonProperty("finalized")]
    public bool IsFinalized { get; init; }
    public decimal Minted { get; init; }
    [JsonProperty("creationTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 CreationTransaction { get; init; } = uint256.Zero;
    public long CreationHeight { get; init; }
    [JsonProperty("destructionTx")]
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 DestructionTransaction { get; init; } = uint256.Zero;
    public long DestructionHeight { get; init; }
    public string CollateralAddress { get; init; } = string.Empty;
}
