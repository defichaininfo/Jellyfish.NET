namespace Jellyfish.Transactions.Script.Expansion;

/// <summary>
/// This instruction allows execution pathways of a script to be restricted based on the age of the output being spent.
/// </summary>
public class OpCheckSequenceVerify : StaticCode
{
    public OpCheckSequenceVerify() : base(0xb2, "OP_CHECKSEQUENCEVERIFY") { }
}
