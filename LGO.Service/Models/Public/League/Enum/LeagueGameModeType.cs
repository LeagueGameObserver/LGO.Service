using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueGameModeType>))]
    public enum LeagueGameModeType
   {
       [JsonProperty("Undefined")]
        Undefined,

        [JsonProperty("Classic5X5")]
        Classic5X5,
        
        [JsonProperty("Aram")]
        Aram,
    }
}