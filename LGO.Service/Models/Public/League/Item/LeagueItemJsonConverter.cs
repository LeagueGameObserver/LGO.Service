using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Item
{
    internal class LeagueItemJsonConverter : JsonConverter<LeagueItem>
    {
        public override void WriteJson(JsonWriter writer, LeagueItem? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }
            
            var retrievalConfiguration = LgoLeagueItemRetrievalConfiguration.GetCurrentOrDefault();

            writer.WriteStartObject();
            
            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Id)));
            serializer.Serialize(writer, value.Id);

            if (retrievalConfiguration.IncludeName)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Name)));
                serializer.Serialize(writer, value.Name);
            }

            if (retrievalConfiguration.IncludePrice)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Price)));
                serializer.Serialize(writer, value.Price);
            }

            if (retrievalConfiguration.IncludeImage)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.PathToImage)));
                serializer.Serialize(writer, value.PathToImage);
            }

            writer.WriteEndObject();
        }

        public override LeagueItem? ReadJson(JsonReader reader, Type objectType, LeagueItem? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}