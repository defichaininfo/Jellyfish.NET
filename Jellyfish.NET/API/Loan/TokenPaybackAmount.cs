namespace Jellyfish.API.Loan;

public class TokenPaybackAmount
{
    /// <summary>
    /// Token to be paid
    /// </summary>
    public string DToken { get; init; } = string.Empty;

    /// <summary>
    /// In "amount@symbol" format to be spent
    /// </summary>
    public string[] Amounts { get; init; } = Array.Empty<string>();
}
