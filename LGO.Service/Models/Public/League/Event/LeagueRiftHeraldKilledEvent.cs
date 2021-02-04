using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueRiftHeraldKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.RiftHeraldKilled;

        public static LeagueRiftHeraldKilledEvent Null => new();
    }
}