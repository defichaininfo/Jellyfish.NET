namespace Jellyfish.API.Loan;

public class CreateVault
{
    /// <summary>
    /// Any valid address or "" to generate a new address
    /// </summary>
    public string OwnerAddress { get; init; } = string.Empty;

    /// <summary>
    /// Unique identifier of the loan scheme (8 chars max). If empty, the default loan scheme will be selected
    /// </summary>
    public string LoanSchemeId { get; init; } = string.Empty;
}
