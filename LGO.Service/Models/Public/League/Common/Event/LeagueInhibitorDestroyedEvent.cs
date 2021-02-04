using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Inhibitor;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueInhibitorDestroyedEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.InhibitorDestroyed;

        public LeagueInhibitor Inhibitor { get; init; } = LeagueInhibitor.Null;

        public static LeagueInhibitorDestroyedEvent Null => new();
    }
}