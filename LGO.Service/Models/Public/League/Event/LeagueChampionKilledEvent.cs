using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueChampionKilledEvent : LeagueKillerWithAssistersGameEvent
    {
        [JsonProperty("Type")]
        public override LeagueGameEventType Type => LeagueGameEventType.ChampionKilled;

        [JsonProperty("VictimSummonerName")]
        public string VictimSummonerName { get; init; } = string.Empty;

        public static LeagueChampionKilledEvent Null => new();
    }
}