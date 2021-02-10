using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueNeutralObjectiveKilledGameEvent : LeagueKillerWithAssistersGameEvent
    {
        [JsonProperty("WasStolen")]
        public bool WasStolen { get; init; } = false;
    }
}