using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Turret;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueTurretDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.TurretDestroyed;

        public LeagueTurret Turret { get; init; } = LeagueTurret.Null;

        public static LeagueTurretDestroyedEvent Null => new();
    }
}