using NBitcoin;
using NBitcoin.JsonConverters;
using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class ListAuctionHistoryDetail
{
    public string Winner { get; init; } = string.Empty;
    public int BlockHeight { get; init; }
    [JsonConverter(typeof(UInt256JsonConverter))]
    public uint256 BlockHash { get; init; } = uint256.Zero;
    [JsonConverter(typeof(DateTimeToUnixTimeConverter))]
    public DateTimeOffset BlockTime { get; init; }
    public string VaultId { get; init; } = string.Empty;
    public int BatchIndex { get; init; }
    public string AuctionBid { get; init; } = string.Empty;
    public string[] AuctionWon { get; init; } = Array.Empty<string>();
}
