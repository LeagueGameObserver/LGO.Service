using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Inhibitor
{
    public record LeagueInhibitor
    {
        public LeagueInhibitorTierType Tier { get; init; } = LeagueInhibitorTierType.Undefined;

        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueInhibitor Null => new();
    }
}