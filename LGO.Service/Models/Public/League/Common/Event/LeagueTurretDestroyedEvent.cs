using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Turret;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueTurretDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.TurretDestroyed;

        public LeagueTurret Turret { get; init; } = LeagueTurret.Null;

        public static LeagueTurretDestroyedEvent Null => new();
    }
}