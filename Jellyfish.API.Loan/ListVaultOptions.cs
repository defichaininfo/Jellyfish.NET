namespace Jellyfish.API.Loan;

public class ListVaultOptions
{
    /// <summary>
    /// Address of the vault owner
    /// </summary>
    public string? OwnerAddress { get; init; } = string.Empty;

    /// <summary>
    /// Vault's loan scheme id
    /// </summary>
    public string? LoanSchemeId { get; init; } = string.Empty;

    /// <summary>
    /// vault's state
    /// </summary>
    public VaultState? State { get; init; }

    public bool? Verbose { get; init; }
}
