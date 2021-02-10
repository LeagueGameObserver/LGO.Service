using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Team
{
    [JsonConverter(typeof(LeagueTeamJsonConverter))]
    public record LeagueTeam : LeagueGoldOwner
    {
        [JsonProperty("Side")]
        public LeagueTeamType Side { get; init; } = LeagueTeamType.Undefined;

        [JsonProperty("DragonsKilled")]
        public IEnumerable<LeagueDragonType> DragonsKilled { get; init; } = Enumerable.Empty<LeagueDragonType>();

        [JsonProperty("NumberOfRiftHeraldsKilled")]
        public int NumberOfRiftHeraldsKilled { get; init; }

        [JsonProperty("NumberOfBaronNashorsKilled")]
        public int NumberOfBaronNashorsKilled { get; init; }

        [JsonProperty("TurretsDestroyed")]
        public IEnumerable<LeagueTurretTier> TurretsDestroyed { get; init; } = Enumerable.Empty<LeagueTurretTier>();

        [JsonProperty("InhibitorsDestroyed")]
        public IEnumerable<LeagueInhibitorTierType> InhibitorsDestroyed { get; init; } = Enumerable.Empty<LeagueInhibitorTierType>();

        public static LeagueTeam Null => new();
    }
}