using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    public class LeaguePowerPlayTimerJsonConverter<TTimer> : LeagueTimerJsonConverter<TTimer> where TTimer : LeaguePowerPlayTimer
    {
        public override void WriteJson(JsonWriter writer, TTimer? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            var retrievalConfiguration = LgoLeaguePowerPlayTimerRetrievalConfiguration.GetCurrentOrDefault();
            
            writer.WriteStartObject();
            
            SerializeProperties(writer, value, serializer);
            
            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Team)));
            serializer.Serialize(writer, value.Team);

            if (retrievalConfiguration.IncludeIsActive)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.IsActive)));
                serializer.Serialize(writer, value.IsActive);
            }

            if (retrievalConfiguration.IncludeMatchUps)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.MatchUps)));
                serializer.Serialize(writer, value.MatchUps);
            }
            
            writer.WriteEndObject();
        }
    }
}