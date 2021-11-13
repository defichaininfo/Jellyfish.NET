namespace Jellyfish.API.Blockchain;

public class Vout
{
    public decimal Value { get; init; }
    public uint N { get; init; }
    public ScriptPubKey ScriptPubKey {  get; init; } = new ScriptPubKey();
    public int TokenId { get; init; }
}
