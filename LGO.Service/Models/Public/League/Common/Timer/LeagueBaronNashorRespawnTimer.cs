using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueBaronNashorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorRespawn;

        public static LeagueBaronNashorRespawnTimer Null => new();
    }
}