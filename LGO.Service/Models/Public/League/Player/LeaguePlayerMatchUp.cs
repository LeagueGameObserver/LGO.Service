using System;
using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Player
{
    public record LeaguePlayerMatchUp : LeagueMatchUp<LeaguePlayer>
    {
        public Guid Id { get; init; } = Guid.Empty;

        public LeaguePositionType Position { get; init; } = LeaguePositionType.Undefined;

        public LeaguePlayer? BlueSideCompetitor { get; init; }

        public LeaguePlayer? RedSideCompetitor { get; init; }

        public int GoldDifference { get; init; }

        public LeagueTeamType WinningTeam { get; init; } = LeagueTeamType.Undefined;

        public static LeaguePlayerMatchUp Null => new();
    }
}