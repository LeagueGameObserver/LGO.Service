using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueGameStateType>))]
    public enum LeagueGameStateType
    {
        [JsonProperty("Undefined")]
        Undefined,

        [JsonProperty("Loading")]
        Loading,
        
        [JsonProperty("InProgress")]
        InProgress,
        
        [JsonProperty("Ended")]
        Ended,
    }
}