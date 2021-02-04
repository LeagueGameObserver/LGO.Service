using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Turret
{
    public record LeagueTurret
    {
        public LeagueTurretTier Tier { get; init; } = LeagueTurretTier.Undefined;

        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueTurret Null => new();
    }
}