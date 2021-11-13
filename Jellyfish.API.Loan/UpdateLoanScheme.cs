using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class UpdateLoanScheme
{
    [JsonProperty("minColRatio")]
    public double MinimumCollateralizationRatio { get; init; }
    public decimal InterestRate { get; init; }
    /// <summary>
    /// Unique identifier of the loan scheme, max 8 chars
    /// </summary>
    public string Id { get; init; } = string.Empty;
    /// <summary>
    /// Block height at which new changes take effect
    /// </summary>
    public long? ActivateAfterBlock { get; init; }
}
