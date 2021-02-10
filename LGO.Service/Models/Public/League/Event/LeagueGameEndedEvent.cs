using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueGameEndedEvent : LeagueGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.GameEnded;

        public static LeagueGameEndedEvent Null => new();
    }
}