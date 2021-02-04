using System;
using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common
{
    public abstract record LeagueMatchUp<TGoldOwner> where TGoldOwner : LeagueGoldOwner
    {
        public Guid Id { get; init; } = Guid.Empty;

        public TGoldOwner? BlueSideCompetitor { get; init; }

        public TGoldOwner? RedSideCompetitor { get; init; }

        public int GoldDifference { get; init; }

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