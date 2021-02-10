using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueRiftHeraldKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.RiftHeraldKilled;

        public static LeagueRiftHeraldKilledEvent Null => new();
    }
}