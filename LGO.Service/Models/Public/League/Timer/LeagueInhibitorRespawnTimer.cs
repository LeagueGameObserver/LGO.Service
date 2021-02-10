using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Inhibitor;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    [JsonConverter(typeof(LeagueTimerJsonConverter<LeagueInhibitorRespawnTimer>))]
    public record LeagueInhibitorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.InhibitorRespawn;

        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorRespawnTimer Null => new();
    }
}