namespace Jellyfish.API.Oracle;

public class ListPricesData
{
    public string Token { get; init; } = string.Empty;
    public string Currency { get; init; } = string.Empty;
    /// <summary>
    /// example: 0.83333333000000
    /// </summary>
    public decimal? Price {  get; init; }
    public bool Ok => ErrorMessage == null;
    public string? ErrorMessage { get; }

    public ListPricesData(object ok)
    {
        if (ok is string error)
        {
            ErrorMessage = error;
        }
    }
}
