using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class CreateLoanScheme
{
    [JsonProperty("minColRatio")]
    public double MinimumCollateralizationRatio { get; init; }
    public decimal InterestRate { get; init; }
    /// <summary>
    /// Unique identifier of the loan scheme, max 8 chars
    /// </summary>
    public string Id { get; init; } = string.Empty;
}
