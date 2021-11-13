namespace Jellyfish.API.Loan;

public class SetCollateralToken
{
    /// <summary>
    /// Symbol or id of collateral token
    /// </summary>
    public string Token { get; init; } = string.Empty;
    public decimal Factor {  get; init; }
    /// <summary>
    /// token/currency pair to use for price of token
    /// </summary>
    public string FixedIntervalPriceId { get; init; } = string.Empty;
    /// <summary>
    /// changes will be active after the block height
    /// </summary>
    public long? ActivateAfterBlock { get; init; }
}
