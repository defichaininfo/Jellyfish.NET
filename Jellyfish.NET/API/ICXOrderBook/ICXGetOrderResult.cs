using Jellyfish.API.ICXOrderBook.Converters;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook;

[JsonConverter(typeof(ICXGetOrderResultConverter))]
public class ICXGetOrderResult
{
    public string? Warning { get; init; }
    public ICXOrderInfo? Order { get; init; }
}
