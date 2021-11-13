using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace Jellyfish.Json;

public class JellyfishJson
{
    public static T? Parse<T>(string text)
    {
        return JsonConvert.DeserializeObject<T>(text);
    }

    public static string Stringify(object obj)
    {
        return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
        {
            DefaultValueHandling = DefaultValueHandling.Ignore,
            Converters = new List<JsonConverter> { new DoubleJsonConverter() },
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        });
    }
}
