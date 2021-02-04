using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeagueDragonRespawnTimer : LeagueTimer
    {
        public override LeagueTimerType Type => LeagueTimerType.DragonRespawn;

        public static LeagueDragonRespawnTimer Null => new();
    }
}