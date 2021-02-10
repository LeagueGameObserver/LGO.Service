using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    public class LeagueTimerJsonConverter<TTimer> : JsonConverter<TTimer> where TTimer : LeagueTimer
    {
        public override void WriteJson(JsonWriter writer, TTimer? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            writer.WriteStartObject();

            SerializeProperties(writer, value, serializer);

            writer.WriteEndObject();
        }

        public override TTimer? ReadJson(JsonReader reader, Type objectType, TTimer? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        protected void SerializeProperties(JsonWriter writer, TTimer value, JsonSerializer serializer)
        {
            var retrievalConfiguration = LgoLeagueTimerRetrievalConfiguration.GetCurrentOrDefault();

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Type)));
            serializer.Serialize(writer, value.Type);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.RemainingTimeInSeconds)));
            serializer.Serialize(writer, value.RemainingTimeInSeconds);

            if (retrievalConfiguration.IncludeGameStartTimeInSeconds)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.GameStartTimeInSeconds)));
                serializer.Serialize(writer, value.GameStartTimeInSeconds);
            }

            if (retrievalConfiguration.IncludeGameEndTimeInSeconds)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.GameEndTimeInSeconds)));
                serializer.Serialize(writer, value.GameEndTimeInSeconds);
            }
        }
    }
}