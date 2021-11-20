using NBitcoin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Jellyfish.API.ICXOrderBook.Converters;

public class ICXGetOrderResultConverter : JsonConverter
{
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        throw new NotImplementedException();
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        string? warning = null;
        ICXOrderInfo? order = null;

        if (reader.TokenType == JsonToken.StartObject)
        {
            var item = JObject.Load(reader);
            foreach (var property in item.Properties())
            {
                if (property.Name.Contains("warning", StringComparison.OrdinalIgnoreCase))
                {
                    warning = property.Value.ToObject<string>();
                }
                else
                {
                    order = property.Value.ToObject<ICXOrderInfo>(serializer);
                }

                if (warning != null && order != null)
                {
                    break;
                }
            }
        }

        return new ICXGetOrderResult
        {
            Warning = warning,
            Order = order
        };
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(ICXGetOrderResult);
    }
}
