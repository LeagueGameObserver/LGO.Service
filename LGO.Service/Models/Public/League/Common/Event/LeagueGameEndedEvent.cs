using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueGameEndedEvent : LeagueGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.GameEnded;

        public static LeagueGameEndedEvent Null => new();
    }
}