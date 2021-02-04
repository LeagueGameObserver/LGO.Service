using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueBaronNashorRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.BaronNashorRespawn;

        public static LeagueBaronNashorRespawnTimer Null => new();
    }
}