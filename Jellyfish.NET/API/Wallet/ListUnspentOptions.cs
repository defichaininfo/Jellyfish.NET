namespace Jellyfish.API.Wallet;

public class ListUnspentOptions
{
    /// <summary>
    /// to filter
    /// </summary>
    public string[]? Addresses { get; init; } = Array.Empty<string>();

    /// <summary>
    /// default = true, include outputs that are not safe to spend
    /// </summary>
    public bool? IncludeUnsafe { get; init; } = true;
    public ListUnspentQueryOptions? QueryOptions { get; init; } = new ListUnspentQueryOptions();
}
