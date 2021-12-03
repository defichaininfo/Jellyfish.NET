namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction allows execution pathways of a script to be restricted based on the age of the output being spent.
/// See <see cref="OpCheckSequenceVerify"/>
/// </summary>
public class OpNop3 : OpCheckSequenceVerify
{

}
