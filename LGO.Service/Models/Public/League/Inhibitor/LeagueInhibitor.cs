using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Inhibitor
{
    public record LeagueInhibitor
    {
        public LeagueInhibitorTierType Tier { get; init; } = LeagueInhibitorTierType.Undefined;

        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueInhibitor Null => new();
    }
}