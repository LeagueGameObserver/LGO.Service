using System;
using LGO.Service.Models.Public.League.Enum;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League
{
    public abstract record LeagueMatchUp<TGoldOwner> where TGoldOwner : LeagueGoldOwner
    {
        [JsonProperty("Id")]
        public Guid Id { get; init; } = Guid.Empty;

        [JsonProperty("BlueSideCompetitor")]
        public TGoldOwner? BlueSideCompetitor { get; init; }

        [JsonProperty("RedSideCompetitor")]
        public TGoldOwner? RedSideCompetitor { get; init; }

        [JsonProperty("GoldDifference")]
        public int GoldDifference { get; init; }

        [JsonProperty("WinningTeam")]
        public LeagueTeamType WinningTeam { get; init; } = LeagueTeamType.Undefined;
    }

    public abstract record LeagueMatchUp : LeagueMatchUp<LeagueGoldOwner>
    {
        public static LeagueMatchUp Null => NullLeagueMatchUp.Get;

        private record NullLeagueMatchUp : LeagueMatchUp
        {
            public static NullLeagueMatchUp Get => new();

            private NullLeagueMatchUp() { }
        }
    }
}