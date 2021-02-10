using LGO.Service.Models.Public.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Enum
{
    [JsonConverter(typeof(EnumJsonConverter<LeagueTimerType>))]
    public enum LeagueTimerType
    {
        [JsonProperty("Undefined")]
        Undefined,
        
        [JsonProperty("DragonRespawn")]
        DragonRespawn,
        
        [JsonProperty("RiftHeraldRespawn")]
        RiftHeraldRespawn,
        
        [JsonProperty("BaronNashorRespawn")]
        BaronNashorRespawn,
        
        [JsonProperty("InhibitorRespawn")]
        InhibitorRespawn,
        
        [JsonProperty("BaronNashorPowerPlay")]
        BaronNashorPowerPlay,
        
        [JsonProperty("ElderDragonPowerPlay")]
        ElderDragonPowerPlay,
    }
}