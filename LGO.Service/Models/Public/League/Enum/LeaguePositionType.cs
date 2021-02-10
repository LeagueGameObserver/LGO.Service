using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeaguePositionType>))]
    public enum LeaguePositionType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("Top")]
        Top,
        
        [JsonProperty("Jungle")]
        Jungle,
        
        [JsonProperty("Middle")]
        Middle,
        
        [JsonProperty("Bottom")]
        Bottom,
        
        [JsonProperty("Support")]
        Support,
    }
}