using System;
using System.Collections.Generic;
using System.Linq;
using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Team
{
    public record LeagueTeam : LeagueGoldOwner
    {
        public Guid Id { get; init; } = Guid.Empty;

        public LeagueTeamType Side { get; init; } = LeagueTeamType.Undefined;

        public IEnumerable<LeagueDragonType> DragonsKilled { get; init; } = Enumerable.Empty<LeagueDragonType>();

        public int NumberOfRiftHeraldsKilled { get; init; }

        public int NumberOfBaronNashorsKilled { get; init; }

        public IEnumerable<LeagueTurretTier> TurretsDestroyed { get; init; } = Enumerable.Empty<LeagueTurretTier>();

        public IEnumerable<LeagueInhibitorTierType> InhibitorsDestroyed { get; init; } = Enumerable.Empty<LeagueInhibitorTierType>();

        public static LeagueTeam Null => new();
    }
}