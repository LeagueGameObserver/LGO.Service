using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueBaronNashorKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.BaronNashorKilled;

        public static LeagueBaronNashorKilledEvent Null => new();
    }
}