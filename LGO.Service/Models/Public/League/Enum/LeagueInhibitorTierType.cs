using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueInhibitorTierType>))]
    public enum LeagueInhibitorTierType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("Undefined")]
        Top,
        
        [JsonProperty("Middle")]
        Middle,
        
        [JsonProperty("Bottom")]
        Bottom,
    }
}