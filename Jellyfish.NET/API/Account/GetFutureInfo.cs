namespace Jellyfish.API.Account;

public class GetFutureInfo
{
    public string Owner { get; init; } = string.Empty;
    public FutureData[] Values { get; init; } = Array.Empty<FutureData>();
}
