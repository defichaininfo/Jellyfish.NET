using Jellyfish.API.ICXOrderBook.Converters;
using NBitcoin;
using Newtonsoft.Json;

namespace Jellyfish.API.ICXOrderBook
{
    [JsonConverter(typeof(ICXListOrdersResultConverter))]
    public class ICXListOrdersResult
    {
        public string? Warning { get; init; }

        public Dictionary<uint256, ICXOrderInfo>? Orders {  get; init; }
    }
}
