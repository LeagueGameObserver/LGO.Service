using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Inhibitor;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueInhibitorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.InhibitorRespawn;

        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorRespawnTimer Null => new();
    }
}