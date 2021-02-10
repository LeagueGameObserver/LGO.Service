using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Team
{
    internal class LeagueTeamJsonConverter : LeagueGoldOwnerJsonConverter<LeagueTeam>
    {
        public override void WriteJson(JsonWriter writer, LeagueTeam? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            var retrievalConfiguration = LgoLeagueTeamRetrievalConfiguration.GetCurrentOrDefault();
            
            writer.WriteStartObject();
            
            base.WriteJson(writer, value, serializer);

            if (retrievalConfiguration.IncludeSide)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Side)));
                serializer.Serialize(writer, value.Side);
            }

            if (retrievalConfiguration.IncludeDragonsKilled)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.DragonsKilled)));
                serializer.Serialize(writer, value.DragonsKilled);
            }

            if (retrievalConfiguration.IncludeNumberOfRiftHeraldsKilled)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.NumberOfRiftHeraldsKilled)));
                serializer.Serialize(writer, value.NumberOfRiftHeraldsKilled);
            }

            if (retrievalConfiguration.IncludeNumberOfBaronNashorsKilled)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.NumberOfBaronNashorsKilled)));
                serializer.Serialize(writer, value.NumberOfBaronNashorsKilled);
            }

            if (retrievalConfiguration.IncludeTurretsDestroyed)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.TurretsDestroyed)));
                serializer.Serialize(writer, value.TurretsDestroyed);
            }

            if (retrievalConfiguration.IncludeInhibitorsDestroyed)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.InhibitorsDestroyed)));
                serializer.Serialize(writer, value.InhibitorsDestroyed);
            }
            
            writer.WriteEndObject();
        }
    }
}