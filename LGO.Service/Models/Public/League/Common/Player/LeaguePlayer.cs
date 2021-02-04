using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Common.Champion;
using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Item;

namespace LGO.Service.Models.Public.League.Common.Player
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