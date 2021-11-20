using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class UpdateLoanToken
{
    /// <summary>
    /// New token's symbol (unique), no longer than 8
    /// </summary>
    public string? Symbol { get; init; }
    /// <summary>
    /// Token's name, no longer than 128
    /// </summary>
    public string? Name { get; init; }
    /// <summary>
    /// token/currency pair to use for price of token
    /// </summary>
    public string? FixedIntervalPriceId { get; init; }
    /// <summary>
    /// Token's 'Mintable' property
    /// </summary>
    [JsonProperty("mintable")]
    public bool? IsMintable { get; init; }
    /// <summary>
    /// Interest rate
    /// </summary>
    public decimal? Interest { get; init; }
}
