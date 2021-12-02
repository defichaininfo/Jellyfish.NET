namespace Jellyfish.Transactions
{
    /// <summary>
    /// TransactionSegWit defines a new messages and serialization formats for propagation of transactions and blocks
    /// committing to a segregated witness structure.
    /// </summary>
    public class SegregatedWitnessTransaction : Transaction
    {
        public int Marker { get; init; }
        public int Flag { get; init; }
        public Witness[] Witness { get; init; } = Array.Empty<Witness>();
    }
}
