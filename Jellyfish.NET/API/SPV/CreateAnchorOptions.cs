namespace Jellyfish.API.SPV;

public class CreateAnchorOptions
{
    /// <summary>
    /// Send to BTC network
    /// </summary>
    public bool? Send { get; init; } = true;

    /// <summary>
    /// Feerate (satoshis) per 1000 bytes
    /// </summary>
    public double? FeeRate { get; init; } = 1000;
}
