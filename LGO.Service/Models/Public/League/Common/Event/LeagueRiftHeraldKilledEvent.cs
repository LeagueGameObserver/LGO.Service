using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueRiftHeraldKilledEvent : LeagueNeutralObjectiveKilledGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.RiftHeraldKilled;

        public static LeagueRiftHeraldKilledEvent Null => new();
    }
}