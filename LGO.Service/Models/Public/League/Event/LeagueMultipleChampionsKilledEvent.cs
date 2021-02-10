using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueMultipleChampionsKilledEvent : LeagueKillerGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.MultipleChampionsKilled;

        [JsonProperty("NumberOfKills")]
        public int NumberOfKills { get; init; }

        public static LeagueMultipleChampionsKilledEvent Null => new();
    }
}