using NBitcoin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jellyfish.API.ICXOrderBook.Converters;

public class ICXListOrdersResultConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        string? warning = null;
        var orders = new Dictionary<uint256, ICXOrderInfo>();

        if (reader.TokenType == JsonToken.StartObject)
        {
            JObject item = JObject.Load(reader);
            foreach (var property in item.Properties())
            {
                if (property.Name.Contains("warning", StringComparison.OrdinalIgnoreCase))
                {
                    warning = property.Value.ToObject<string>();
                }
                else
                {
                    var key = uint256.Parse(property.Name);
                    orders.Add(key, property.Value.ToObject<ICXOrderInfo>(serializer));
                }
            }
        }

        return new ICXListOrdersResult
        {
            Warning = warning,
            Orders = orders
        };
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(ICXListOrdersResult);
    }
}
