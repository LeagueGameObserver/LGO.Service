using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueKillerGameEvent : LeagueGameEvent
    {
        [JsonProperty("KillerName")]
        public string KillerName { get; init; } = string.Empty;
    }
}