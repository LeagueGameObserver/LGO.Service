using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Turret;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueTurretDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.TurretDestroyed;

        [JsonProperty("Turret")]
        public LeagueTurret Turret { get; init; } = LeagueTurret.Null;

        public static LeagueTurretDestroyedEvent Null => new();
    }
}