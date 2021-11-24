namespace Jellyfish.Network;

public class MasterNodeKey
{
    public KeyPair Owner { get; init; } = new();
    public KeyPair Operator { get; init; } = new();
}
