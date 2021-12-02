namespace Jellyfish.Transactions;

/// <summary>
/// Like bitcoin, DeFi uses a scripting system for transactions.
/// Script is simple, stack-based, and processed from left to right
/// It is intentionally none Turing-complete, with no loops.
/// </summary>
public class Script
{
    public OPCode[] Stack { get; init; } = Array.Empty<OPCode>();
}
