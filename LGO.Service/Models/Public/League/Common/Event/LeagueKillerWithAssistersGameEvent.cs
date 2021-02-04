using System.Collections.Generic;
using System.Linq;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public abstract record LeagueKillerWithAssistersGameEvent : LeagueKillerGameEvent
    {
        public IEnumerable<string> AssisterNames { get; init; } = Enumerable.Empty<string>();
    }
}