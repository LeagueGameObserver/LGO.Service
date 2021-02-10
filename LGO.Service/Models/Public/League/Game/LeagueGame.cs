using System;
using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Enum;
using LGO.Service.Models.Public.League.Event;
using LGO.Service.Models.Public.League.Player;
using LGO.Service.Models.Public.League.Team;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Game
{
    [JsonConverter(typeof(LeagueGameJsonConverter))]
    public record LeagueGame
    {
        [JsonProperty("Id")]
        public Guid Id { get; init; } = Guid.Empty;

        [JsonProperty("GameTimeInSeconds")]
        public double GameTimeInSeconds { get; init; }
        
        [JsonProperty("State")]
        public LeagueGameStateType State { get; init; } = LeagueGameStateType.Undefined;

        [JsonProperty("Mode")]
        public LeagueGameModeType Mode { get; init; } = LeagueGameModeType.Undefined;

        [JsonProperty("Teams")]
        public IEnumerable<LeagueTeam> Teams { get; init; } = Enumerable.Empty<LeagueTeam>();

        [JsonProperty("Players")]
        public IEnumerable<LeaguePlayer> Players { get; init; } = Enumerable.Empty<LeaguePlayer>();

        [JsonProperty("MatchUps")]
        public IEnumerable<LeagueMatchUp> MatchUps { get; init; } = Enumerable.Empty<LeagueMatchUp>();

        [JsonProperty("Timers")]
        public IEnumerable<LeagueTimer> Timers { get; init; } = Enumerable.Empty<LeagueTimer>();

        [JsonProperty("Events")]
        public IEnumerable<LeagueGameEvent> Events { get; init; } = Enumerable.Empty<LeagueGameEvent>();

        [JsonProperty("EventsSinceLastUpdate")]
        public IEnumerable<LeagueGameEvent> EventsSinceLastUpdate { get; init; } = Enumerable.Empty<LeagueGameEvent>();

        public static LeagueGame Null => new();
    }
}