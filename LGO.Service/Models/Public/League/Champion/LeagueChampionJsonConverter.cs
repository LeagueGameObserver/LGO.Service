using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Champion
{
    internal class LeagueChampionJsonConverter : JsonConverter<LeagueChampion>
    {
        public override void WriteJson(JsonWriter writer, LeagueChampion? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }
            
            var retrievalConfiguration = LgoLeagueChampionRetrievalConfiguration.GetCurrentOrDefault();

            writer.WriteStartObject();

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Id)));
            serializer.Serialize(writer, value.Id);

            if (retrievalConfiguration.IncludeName)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Name)));
                serializer.Serialize(writer, value.Name);
            }

            if (retrievalConfiguration.IncludeTileImage)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.PathToTileImage)));
                serializer.Serialize(writer, value.PathToTileImage);
            }

            if (retrievalConfiguration.IncludeSplashImage)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.PathToSplashImage)));
                serializer.Serialize(writer, value.PathToSplashImage);
            }

            if (retrievalConfiguration.IncludeLoadingImage)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.PathToLoadingImage)));
                serializer.Serialize(writer, value.PathToLoadingImage);
            }

            writer.WriteEndObject();
        }

        public override LeagueChampion? ReadJson(JsonReader reader, Type objectType, LeagueChampion? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}