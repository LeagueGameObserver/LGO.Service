using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Inhibitor;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueInhibitorDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.InhibitorDestroyed;

        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorDestroyedEvent Null => new();
    }
}