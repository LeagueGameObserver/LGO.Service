using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Timer;

namespace LGO.Service.Models.Public.League.Common
{
    public abstract record LeagueTimer
    {
        public abstract LeagueTimerType Type { get; }

        public double RemainingTimeInSeconds { get; init; }

        public double GameStartTimeInSeconds { get; init; }

        public double GameEndTimeInSeconds { get; init; }
    }

    public abstract record LeaguePowerPlayTimer : LeagueTimer
    {
        public LeagueTeamType Team { get; init; } = LeagueTeamType.Undefined;

        public bool IsActive { get; init; } = false;

        public IEnumerable<LeaguePowerPlayMatchUp> MatchUps { get; init; } = Enumerable.Empty<LeaguePowerPlayMatchUp>();
    }
}