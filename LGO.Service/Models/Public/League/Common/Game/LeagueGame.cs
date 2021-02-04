using System;
using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Common.Enum;
using LGO.Service.Models.Public.League.Common.Event;
using LGO.Service.Models.Public.League.Common.Player;
using LGO.Service.Models.Public.League.Common.Team;

namespace LGO.Service.Models.Public.League.Common.Game
{
    public record LeagueGame
    {
        public Guid Id { get; init; } = Guid.Empty;

        public double GameTimeInSeconds { get; init; }
        
        public LeagueGameStateType State { get; init; } = LeagueGameStateType.Undefined;

        public LeagueGameModeType Mode { get; init; } = LeagueGameModeType.Undefined;

        public IEnumerable<LeagueTeam> Teams { get; init; } = Enumerable.Empty<LeagueTeam>();

        public IEnumerable<LeaguePlayer> Players { get; init; } = Enumerable.Empty<LeaguePlayer>();

        public IEnumerable<LeagueMatchUp> MatchUps { get; init; } = Enumerable.Empty<LeagueMatchUp>();

        public IEnumerable<LeagueTimer> Timers { get; init; } = Enumerable.Empty<LeagueTimer>();

        public IEnumerable<LeagueGameEvent> Events { get; init; } = Enumerable.Empty<LeagueGameEvent>();

        public IEnumerable<LeagueGameEvent> EventsSinceLastUpdate { get; init; } = Enumerable.Empty<LeagueGameEvent>();

        public static LeagueGame Null => new();
    }
}