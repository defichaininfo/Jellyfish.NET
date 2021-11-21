using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.PoolPair;

public class PoolPairInfo
{
    public string Symbol { get; init; } = string.Empty;
    public string Name { get; init; } = string.Empty;
    public bool Status { get; init; }
    public string IdTokenA { get; init; } = string.Empty;
    public string IdTokenB { get; init; } = string.Empty;
    public decimal ReserveA { get; init; }
    public decimal ReserveB { get; init; }
    public decimal Commission { get; init; }
    public decimal TotalLiquidity { get; init; }
    [JsonProperty("reserveA/reserveB")]
    public object? ReserveAToReserveB { get; init; }
    [JsonProperty("reserveB/reserveA")]
    public object? ReserveBToReserveA { get; init; }
    public bool TradeEnabled { get; init; }
    public string OwnerAddress { get; init; } = string.Empty;
    public decimal BlockCommissionA { get; init; }
    public decimal BlockCommissionB { get; init; }
    public decimal RewardPct { get; init; }
    public string[]? CustomRewards { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 CreationTransaction { get; init; } = uint256.Zero;
    public long CreationHeight { get; init; }
}
