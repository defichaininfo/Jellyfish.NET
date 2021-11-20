using Newtonsoft.Json;

namespace Jellyfish.API.Loan;

public class Vault
{
    public string VaultId { get; init; } = string.Empty;
    public string LoanSchemeId { get; init; } = string.Empty;
    public string OwnerAddress { get; init; } = string.Empty;
    public VaultState State { get; init; }
}
