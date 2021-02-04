using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Inhibitor;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueInhibitorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.InhibitorRespawn;

        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorRespawnTimer Null => new();
    }
}