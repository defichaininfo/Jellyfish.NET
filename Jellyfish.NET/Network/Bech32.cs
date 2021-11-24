namespace Jellyfish.Network;

public class Bech32
{
    /// <summary>
    /// bech32 human readable part
    /// </summary>
    public string HumanReadablePart { get; }

    public Bech32(string humanReadablePart)
    {
        HumanReadablePart = humanReadablePart;
    }
}
