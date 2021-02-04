using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueRiftHeraldRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.RiftHeraldRespawn;

        public static LeagueRiftHeraldRespawnTimer Null => new();
    }
}