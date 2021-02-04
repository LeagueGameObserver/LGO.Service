using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeagueDragonRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.DragonRespawn;

        public static LeagueDragonRespawnTimer Null => new();
    }
}