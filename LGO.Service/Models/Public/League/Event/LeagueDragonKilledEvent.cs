using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueDragonKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.DragonKilled;

        public LeagueDragonType Dragon { get; init; } = LeagueDragonType.Undefined;

        public static LeagueDragonKilledEvent Null => new();
    }
}