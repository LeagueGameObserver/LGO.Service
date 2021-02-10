using System;
using LGO.Service.Models.Internal;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League
{
    public abstract class LeagueGoldOwnerJsonConverter<TImplementation> : JsonConverter<TImplementation> where TImplementation : LeagueGoldOwner
    {
        public override void WriteJson(JsonWriter writer, TImplementation? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.Id)));
            serializer.Serialize(writer, value.Id);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.TotalGoldOwned)));
            serializer.Serialize(writer, value.TotalGoldOwned);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.UnspentKills)));
            serializer.Serialize(writer, value.UnspentKills);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.UnspentAssists)));
            serializer.Serialize(writer, value.UnspentAssists);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.UnspentDeaths)));
            serializer.Serialize(writer, value.UnspentDeaths);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.TotalKills)));
            serializer.Serialize(writer, value.TotalKills);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.TotalAssists)));
            serializer.Serialize(writer, value.TotalAssists);

            writer.WritePropertyName(JsonSerializationHelper.GetPropertyName(value.GetType(), nameof(value.TotalDeaths)));
            serializer.Serialize(writer, value.TotalDeaths);
        }

        public override TImplementation? ReadJson(JsonReader reader, Type objectType, TImplementation? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}