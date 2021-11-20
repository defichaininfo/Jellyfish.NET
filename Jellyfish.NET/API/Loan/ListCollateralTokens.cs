namespace Jellyfish.API.Loan;

public class ListCollateralTokens
{
    /// <summary>
    /// Valid at specified height, leave empty for current block height
    /// </summary>
    public int? Height { get; init; }

    /// <summary>
    /// True = All transactions, false = Activated transactions
    /// </summary>
    public bool? All { get; init; }
}
