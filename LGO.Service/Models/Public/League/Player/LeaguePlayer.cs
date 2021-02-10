using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Champion;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Item;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Player
{
    [JsonConverter(typeof(LeaguePlayerJsonConverter))]
    public record LeaguePlayer : LeagueGoldOwner
    {
        [JsonProperty("SummonerName")]
        public string SummonerName { get; init; } = string.Empty;

        [JsonProperty("Team")]
        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        [JsonProperty("Champion")]
        public LeagueChampion Champion { get; init; } = LeagueChampion.Null;

        [JsonProperty("Items")]
        public IEnumerable<LeagueItem> Items { get; init; } = Enumerable.Empty<LeagueItem>();

        public static LeaguePlayer Null => new();
    }
}