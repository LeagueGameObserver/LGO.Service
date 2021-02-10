using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueGameStartedEvent : LeagueGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.GameStarted;

        public static LeagueGameStartedEvent Null => new();
    }
}