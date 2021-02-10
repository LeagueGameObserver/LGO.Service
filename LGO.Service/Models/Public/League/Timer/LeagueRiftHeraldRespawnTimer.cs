using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeagueTimerJsonConverter<LeagueRiftHeraldRespawnTimer>))]
    public record LeagueRiftHeraldRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.RiftHeraldRespawn;

        public static LeagueRiftHeraldRespawnTimer Null => new();
    }
}