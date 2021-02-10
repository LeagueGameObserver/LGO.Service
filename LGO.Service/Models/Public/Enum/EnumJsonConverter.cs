using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Enum
{
    public class EnumJsonConverter<TEnum> : JsonConverter<TEnum> where TEnum : System.Enum
    {
        public override void WriteJson(JsonWriter writer, TEnum? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }
            
            writer.WriteValue(JsonSerializationHelper.GetPropertyName(value.GetType(), value.ToString()));
        }

        public override TEnum? ReadJson(JsonReader reader, Type objectType, TEnum? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}