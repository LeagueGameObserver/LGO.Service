using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueBaronNashorKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.BaronNashorKilled;

        public static LeagueBaronNashorKilledEvent Null => new();
    }
}