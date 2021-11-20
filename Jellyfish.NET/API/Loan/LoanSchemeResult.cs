using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class LoanSchemeResult
{
    public string Id { get; init; } = string.Empty;
    [JsonProperty("minColRatio")]
    public decimal MinimumCollateralizationRatio { get; init; }
    public decimal InterestRate { get; init; }
    [JsonProperty("default")]
    public bool IsDefault { get; init; }
}
