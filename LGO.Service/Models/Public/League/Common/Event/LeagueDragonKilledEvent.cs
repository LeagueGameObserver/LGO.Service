using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueDragonKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.DragonKilled;

        public LeagueDragonType Dragon { get; init; } = LeagueDragonType.Undefined;

        public static LeagueDragonKilledEvent Null => new();
    }
}