using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Inhibitor
{
    public record LeagueInhibitor
    {
        [JsonProperty("Tier")]
        public LeagueInhibitorTierType Tier { get; init; } = LeagueInhibitorTierType.Undefined;

        [JsonProperty("Team")]
        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueInhibitor Null => new();
    }
}