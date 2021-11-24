namespace Jellyfish.Network;

public class Bip32
{
    /// <summary>
    /// base58Prefixes.EXT_PUBLIC_KEY
    /// </summary>
    public int PublicPrefix { get; }

    /// <summary>
    /// base58Prefixes.EXT_SECRET_KEY
    /// </summary>
    public int PrivatePrefix { get; }

    public Bip32(int publicPrefix, int privatePrefix)
    {
        PublicPrefix = publicPrefix;
        PrivatePrefix = privatePrefix;
    }
}
