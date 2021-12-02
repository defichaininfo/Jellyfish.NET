namespace Jellyfish.Transactions;

/// <summary>
/// An output contains instructions for sending DFI.
/// OP_RETURN script are usually custom transaction for DeFi related transaction.
/// 
/// script is 'scriptPubKey' in Vout
/// 
/// Also know as Transaction Out, TxOut, VectorOut, RedeemOut, Creating UTXO.
/// </summary>
public class Vout
{
    public decimal Value { get; init; }
    public Script Script { get; init; }
    public int TokenId { get; init; }
}
