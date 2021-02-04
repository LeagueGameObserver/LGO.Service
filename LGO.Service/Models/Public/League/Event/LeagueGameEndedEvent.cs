using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueGameEndedEvent : LeagueGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.GameEnded;

        public static LeagueGameEndedEvent Null => new();
    }
}