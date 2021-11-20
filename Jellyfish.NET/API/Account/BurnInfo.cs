namespace Jellyfish.API.Account;

public class BurnInfo
{
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// Amount sent to burn address
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Token amount sent to burn address
    /// </summary>
    public string[] Tokens { get; init; } = Array.Empty<string>();

    /// <summary>
    /// Amount collected via fee burn
    /// </summary>
    public decimal FeeBurn { get; init; }

    /// <summary>
    /// Amount collected via emission burn
    /// </summary>
    public decimal EmissionBurn { get; init; }
}
