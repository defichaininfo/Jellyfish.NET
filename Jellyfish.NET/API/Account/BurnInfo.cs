namespace Jellyfish.API.Account;

public class BurnInfo
{
    public string Address { get; init; } = string.Empty;

    /// <summary>
    /// Amount sent to burn address
    /// </summary>
    public decimal Amount { get; init; }

    /// <summary>
    /// Token amount send to burn address; formatted as AMOUNT@SYMBOL
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

    /// <summary>
    /// Value of burn after payback
    /// </summary>
    public decimal PaybackBurn { get; init; }

    /// <summary>
    /// Formatted as AMOUNT@SYMBOL
    /// </summary>
    public string[] DexFeeTokens { get; init; } = Array.Empty<string>();

    /// <summary>
    /// Amount of DFI collected from penalty resulting from paying DUSD using DFI
    /// </summary>
    public decimal DFIPaybackFee { get; init; }

    /// <summary>
    /// Amount of tokens that are paid back; formatted as AMOUNT@SYMBOL
    /// </summary>
    public string[] DFIPaybackTokens { get; init; } = Array.Empty<string>();
}
