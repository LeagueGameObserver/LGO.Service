using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Timer;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League
{
    public abstract record LeagueTimer
    {
        [JsonProperty("Type")]
        public abstract LeagueTimerType Type { get; }

        [JsonProperty("RemainingTimeInSeconds")]
        public double RemainingTimeInSeconds { get; init; }

        [JsonProperty("GameStartTimeInSeconds")]
        public double GameStartTimeInSeconds { get; init; }

        [JsonProperty("GameEndTimeInSeconds")]
        public double GameEndTimeInSeconds { get; init; }
    }

    public abstract record LeaguePowerPlayTimer : LeagueTimer
    {
        [JsonProperty("Team")]
        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        [JsonProperty("IsActive")]
        public bool IsActive { get; init; } = false;

        [JsonProperty("MatchUps")]
        public IEnumerable<LeaguePowerPlayMatchUp> MatchUps { get; init; } = Enumerable.Empty<LeaguePowerPlayMatchUp>();
    }
}