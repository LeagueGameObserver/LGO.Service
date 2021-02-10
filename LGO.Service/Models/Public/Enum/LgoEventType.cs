using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LgoEventType>))]
    public enum LgoEventType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("LeagueGameStateChanged")]
        LeagueGameStateChanged,
        
        [JsonProperty("LeagueGameUpdated")]
        LeagueGameUpdated,
    }
}