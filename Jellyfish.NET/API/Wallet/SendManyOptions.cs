using Newtonsoft.Json;

namespace Jellyfish.API.Wallet;

public class SendManyOptions
{
    /// <summary>
    /// A comment
    /// </summary>
    public string? Comment { get; init; } = string.Empty;

    /// <summary>
    /// Allow this transaction to be replaced by a transaction with higher fees via BIP 125
    /// </summary>
    [JsonProperty("replaceable")]
    public bool? IsReplaceable { get; init; } = false;

    /// <summary>
    /// Confirmation target (in blocks)
    /// </summary>
    [JsonProperty("confTarget")]
    public int? ConfirmationTarget { get; init; } = 6;

    /// <summary>
    /// The fee estimate mode, must be one of (Mode.UNSET, Mode.ECONOMICAL, Mode.CONSERVATIVE)
    /// </summary>
    public Mode EstimateMode { get; init; }
}
