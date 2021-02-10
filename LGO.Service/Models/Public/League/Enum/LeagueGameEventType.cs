using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueGameEventType>))]
    public enum LeagueGameEventType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("GameStarted")]
        GameStarted,
        
        [JsonProperty("TurretDestroyed")]
        TurretDestroyed,
        
        [JsonProperty("InhibitorDestroyed")]
        InhibitorDestroyed,
        
        [JsonProperty("DragonKilled")]
        DragonKilled,
        
        [JsonProperty("RiftHeraldKilled")]
        RiftHeraldKilled,
        
        [JsonProperty("BaronNashorKilled")]
        BaronNashorKilled,
        
        [JsonProperty("ChampionKilled")]
        ChampionKilled,
        
        [JsonProperty("MultipleChampionsKilled")]
        MultipleChampionsKilled,
        
        [JsonProperty("TeamKilled")]
        TeamKilled,
        
        [JsonProperty("ItemsChanged")]
        ItemsChanged,
        
        [JsonProperty("GameEnded")]
        GameEnded,
    }
}