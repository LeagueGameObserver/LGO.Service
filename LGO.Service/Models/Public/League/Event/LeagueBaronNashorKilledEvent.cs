using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueBaronNashorKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.BaronNashorKilled;

        public static LeagueBaronNashorKilledEvent Null => new();
    }
}