using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Turret
{
    public record LeagueTurret
    {
        [JsonProperty("Tier")]
        public LeagueTurretTier Tier { get; init; } = LeagueTurretTier.Undefined;

        [JsonProperty("Team")]
        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public static LeagueTurret Null => new();
    }
}