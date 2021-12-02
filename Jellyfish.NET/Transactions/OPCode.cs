namespace Jellyfish.Transactions;

/// <summary>
/// Operation code, script words, opcodes, commands and functions there are many names to this.
/// This is essentially things to be pushed into the DeFi scripting stack.
/// 
/// Like bitcoin, it uses a scripting system for transactions.
/// Script is simple, stack-based, and processed from left to right.
/// It is intentionally none Turing-complete, with no loops.
/// /// </summary>
public abstract class OPCode
{
    public string Type { get; }

    protected OPCode(string type)
    {
        Type = type;
    }
}
