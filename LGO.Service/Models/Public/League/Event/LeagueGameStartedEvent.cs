using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueGameStartedEvent : LeagueGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.GameStarted;

        public static LeagueGameStartedEvent Null => new();
    }
}