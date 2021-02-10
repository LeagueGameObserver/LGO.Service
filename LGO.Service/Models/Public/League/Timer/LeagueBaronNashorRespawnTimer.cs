using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeagueTimerJsonConverter<LeagueBaronNashorRespawnTimer>))]
    public record LeagueBaronNashorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorRespawn;

        public static LeagueBaronNashorRespawnTimer Null => new();
    }
}