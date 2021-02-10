using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueGameEvent
    {
        [JsonProperty("Type")]
        public abstract LeagueGameEventType Type { get; }
        
        [JsonProperty("GameTimeInSeconds")]
        public double GameTimeInSeconds { get; init; }
    }
}