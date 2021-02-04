using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Item;
using LGO.Service.Models.Public.League.Player;

namespace LGO.Service.Models.Public.League.Event
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