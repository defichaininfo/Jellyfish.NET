namespace Jellyfish.Transactions;

/// <summary>
/// An input is a reference to an output from a previous transaction.
/// Multiple inputs are often listed in a transaction.
/// 
/// script is 'scriptSig' in Vin
/// 
/// Also know as Transaction In, TxIn, VectorIn, Spending UTXO.
/// </summary>
public class Vin
{
    public string TxId { get; init; } = string.Empty;
    public int Index { get; init; }
    public Script Script { get; init; }
    public int Sequence { get; init; }
}
