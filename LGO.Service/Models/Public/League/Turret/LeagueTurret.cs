using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Turret
{
    public record LeagueTurret
    {
        public LeagueTurretTier Tier { get; init; } = LeagueTurretTier.Undefined;

        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueTurret Null => new();
    }
}