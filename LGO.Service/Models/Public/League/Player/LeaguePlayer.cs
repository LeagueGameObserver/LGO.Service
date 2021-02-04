using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Champion;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Item;

namespace LGO.Service.Models.Public.League.Player
{
    public record LeaguePlayer : LeagueGoldOwner
    {
        public string SummonerName { get; init; } = string.Empty;

        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public LeagueChampion Champion { get; init; } = LeagueChampion.Null;

        public IEnumerable<LeagueItem> Items { get; init; } = Enumerable.Empty<LeagueItem>();

        public static LeaguePlayer Null => new();
    }
}