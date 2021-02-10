using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Player
{
    internal class LeaguePlayerJsonConverter : LeagueGoldOwnerJsonConverter<LeaguePlayer>
    {
        public override void WriteJson(JsonWriter writer, LeaguePlayer? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            var retrievalConfiguration = LgoLeaguePlayerRetrievalConfiguration.GetCurrentOrDefault();

            writer.WriteStartObject();

            base.WriteJson(writer, value, serializer);

            if (retrievalConfiguration.IncludeSummonerName)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.SummonerName)));
                serializer.Serialize(writer, value.SummonerName);
            }

            if (retrievalConfiguration.IncludeTeam)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Team)));
                serializer.Serialize(writer, value.Team);
            }

            if (retrievalConfiguration.IncludeChampion)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Champion)));
                serializer.Serialize(writer, value.Champion);
            }

            if (retrievalConfiguration.IncludeItems)
            {
                writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Items)));
                serializer.Serialize(writer, value.Items);
            }

            writer.WriteEndObject();
        }
    }
}