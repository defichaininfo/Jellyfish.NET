namespace Jellyfish.API.Account;

public class ListFutureInfo
{
    public string Owner { get; init; } = string.Empty;
    public string Source { get; init; } = string.Empty; // eg: '1.234@DUSD'
    public string Destination { get; init; } = string.Empty;
}
