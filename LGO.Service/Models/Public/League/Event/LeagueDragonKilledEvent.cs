using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueDragonKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.DragonKilled;

        [JsonProperty("Dragon")]
        public LeagueDragonType Dragon { get; init; } = LeagueDragonType.Undefined;

        public static LeagueDragonKilledEvent Null => new();
    }
}