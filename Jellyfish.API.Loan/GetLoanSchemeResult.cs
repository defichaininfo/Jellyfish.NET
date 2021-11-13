using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class GetLoanSchemeResult
{
    /// <summary>
    /// Unique identifier of the loan scheme, max 8 chars
    /// </summary>
    public string Id { get; init; } = string.Empty;
    public decimal InterestRate { get; init; }
    [JsonProperty("minColRatio")]
    public double MinimumCollateralizationRatio { get; init; }
    [JsonProperty("default")]
    public bool IsDefault { get; init; }
}
