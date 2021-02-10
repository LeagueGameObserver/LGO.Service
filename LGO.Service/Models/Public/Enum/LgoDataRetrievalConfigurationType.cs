using Newtonsoft.Json;

namespace LGO.Service.Models.Public.Enum
{
    [JsonConverter(typeof(LgoDataRetrievalConfigurationType))]
    public enum LgoDataRetrievalConfigurationType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("LeagueItem")]
        LeagueItem,
        
        [JsonProperty("LeagueChampion")]
        LeagueChampion,
        
        [JsonProperty("LeaguePlayer")]
        LeaguePlayer,
        
        [JsonProperty("LeagueTeam")]
        LeagueTeam,
        
        [JsonProperty("LeagueTimer")]
        LeagueTimer,
        
        [JsonProperty("LeaguePowerPlayTimer")]
        LeaguePowerPlayTimer,
        
        [JsonProperty("LeagueGame")]
        LeagueGame,
    }
}