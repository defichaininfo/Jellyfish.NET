using Newtonsoft.Json;

namespace Jellyfish.API.RawTransaction;

public class CreateRawTxOptions
{
    public int? LockTime { get; init; } = 0;
    [JsonProperty("replaceable")]
    public bool? IsReplaceable { get; init; } = false;
}
