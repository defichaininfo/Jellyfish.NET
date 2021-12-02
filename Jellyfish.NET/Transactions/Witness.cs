namespace Jellyfish.Transactions;

/// <summary>
/// Script witness consist of a stack of byte arrays.
/// 
/// Each vin has its own script witness. The number of script witnesses is not explicitly encoded as it is implied by
/// count(vin): 'count(vin) x Witness', hence the VarUInt is omitted.
/// Each witness program is linked to a vin of the same index.
/// 
/// Inside each script witness, it is encoded as a var_int item count followed by each item encoded as a var_int length
/// followed by a string of bytes.
/// </summary>
public class Witness
{
    public WitnessScript[] Scripts { get; init; } = Array.Empty<WitnessScript>();
}
