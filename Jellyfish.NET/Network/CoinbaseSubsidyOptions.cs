namespace Jellyfish.Network;

public class CoinbaseSubsidyOptions
{
    public int EunosHeight { get; init; }
    public decimal GenesisBlockSubsidy { get; init; }
    public decimal PreEunosBlockSubsidy { get; init; } = 20000000000;
    public decimal EunosBaseBlockSubsidy { get; init; } = 40504000000;
    public decimal EunosFoundationBurn { get; init; }
    public int EmissionReduction { get; init; } = 1658;
    public int EmissionReductionInterval { get; init; } = 32690;
}
