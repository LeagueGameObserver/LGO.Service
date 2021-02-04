using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Item;
using LGO.Service.Models.Public.League.Common.Player;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueItemsChangedEvent : LeagueGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.ItemsChanged;

        public LeaguePlayer Player { get; init; } = LeaguePlayer.Null;

        public IEnumerable<LeagueItem> AddedItems { get; init; } = Enumerable.Empty<LeagueItem>();

        public IEnumerable<LeagueItem> RemovedItems { get; init; } = Enumerable.Empty<LeagueItem>();

        public static LeagueItemsChangedEvent Null => new();
    }
}