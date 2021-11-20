namespace Jellyfish.API.ICXOrderBook;

public class ListHTLCsResult
{
    public string? Warning { get; init; }
    public Dictionary<string, object>? HTLCs { get; init; }
}
