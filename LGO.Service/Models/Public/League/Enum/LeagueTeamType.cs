using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueTeamType>))]
    public enum LeagueTeamType
    {
        [JsonProperty("Undefined")]
        Undefined,

        [JsonProperty("Blue")]
        Blue,
        
        [JsonProperty("Red")]
        Red,
        
        [JsonProperty("Neutral")]
        Neutral,
    }
}