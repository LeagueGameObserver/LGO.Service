using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueMultipleChampionsKilledEvent : LeagueKillerGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.MultipleChampionsKilled;

        public int NumberOfKills { get; init; }

        public static LeagueMultipleChampionsKilledEvent Null => new();
    }
}