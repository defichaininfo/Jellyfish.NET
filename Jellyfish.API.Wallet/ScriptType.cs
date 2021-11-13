namespace Jellyfish.API.Wallet;

public enum ScriptType
{
    NonStandard,
    PubKey,
    PubKeyHash,
    ScriptHash,
    MultiSig,
    NullData,
    Witness_V0_KeyHash,
    Witness_Unknown
}
