using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Game
{
    public class LeagueGameJsonConverter : JsonConverter<LeagueGame>
    {
        public override void WriteJson(JsonWriter writer, LeagueGame? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            var retrievalConfiguration = LgoLeagueGameRetrievalConfiguration.GetCurrentOrDefault();
            
            writer.WriteStartObject();
            
            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Id)));
            serializer.Serialize(writer, value.Id);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.State)));
            serializer.Serialize(writer, value.State);
            
            if (retrievalConfiguration.IncludeGameTimeInSeconds)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.GameTimeInSeconds)));
                serializer.Serialize(writer, value.GameTimeInSeconds);
            }

            if (retrievalConfiguration.IncludeMode)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Mode)));
                serializer.Serialize(writer, value.Mode);
            }

            if (retrievalConfiguration.IncludeTeams)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Teams)));
                serializer.Serialize(writer, value.Teams);
            }

            if (retrievalConfiguration.IncludePlayers)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Players)));
                serializer.Serialize(writer, value.Players);
            }

            if (retrievalConfiguration.IncludeMatchUps)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.MatchUps)));
                serializer.Serialize(writer, value.MatchUps);
            }

            if (retrievalConfiguration.IncludeTimers)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Timers)));
                serializer.Serialize(writer, value.Timers);
            }

            if (retrievalConfiguration.IncludeEvents)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Events)));
                serializer.Serialize(writer, value.Events);
            }

            if (retrievalConfiguration.IncludeEventsSinceLastUpdate)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.EventsSinceLastUpdate)));
                serializer.Serialize(writer, value.EventsSinceLastUpdate);
            }
            
            writer.WriteEndObject();
        }

        public override LeagueGame? ReadJson(JsonReader reader, Type objectType, LeagueGame? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}