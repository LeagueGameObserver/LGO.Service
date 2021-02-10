using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Item;
using LGO.Service.Models.Public.League.Player;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueItemsChangedEvent : LeagueGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.ItemsChanged;

        [JsonProperty("Player")]
        public LeaguePlayer Player { get; init; } = LeaguePlayer.Null;

        [JsonProperty("AddedItems")]
        public IEnumerable<LeagueItem> AddedItems { get; init; } = Enumerable.Empty<LeagueItem>();

        [JsonProperty("RemovedItems")]
        public IEnumerable<LeagueItem> RemovedItems { get; init; } = Enumerable.Empty<LeagueItem>();

        public static LeagueItemsChangedEvent Null => new();
    }
}