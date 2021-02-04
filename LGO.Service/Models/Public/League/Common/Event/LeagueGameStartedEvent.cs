using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueGameStartedEvent : LeagueGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.GameStarted;

        public static LeagueGameStartedEvent Null => new();
    }
}