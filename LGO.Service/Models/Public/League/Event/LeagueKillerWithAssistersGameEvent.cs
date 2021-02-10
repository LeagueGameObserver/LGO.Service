using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueKillerWithAssistersGameEvent : LeagueKillerGameEvent
    {
        [JsonProperty("AssisertNames")]
        public IEnumerable<string> AssisterNames { get; init; } = Enumerable.Empty<string>();
    }
}