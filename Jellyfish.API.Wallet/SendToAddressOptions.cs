using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class SendToAddressOptions
{
    public string? Comment { get; init; } = string.Empty;
    public string? CommentTo { get; init; } = string.Empty;
    public bool? SubtractFeeFromAmount { get; init; } = false;
    [JsonProperty("replaceable")]
    public bool? IsReplaceable { get; init; } = false;
    [JsonProperty("confTarget")]
    public int? ConfirmationTarget { get; init; } = 6;
    public Mode EstimateMode { get; init; }
    public bool? AvoidReuse { get; init; } = false;
}
