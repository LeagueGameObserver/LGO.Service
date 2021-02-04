using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueRiftHeraldRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.RiftHeraldRespawn;

        public static LeagueRiftHeraldRespawnTimer Null => new();
    }
}