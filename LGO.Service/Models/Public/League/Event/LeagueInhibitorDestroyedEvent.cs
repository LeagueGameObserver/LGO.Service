using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Inhibitor;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueInhibitorDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.InhibitorDestroyed;

        [JsonProperty("Inhibitor")]
        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorDestroyedEvent Null => new();
    }
}