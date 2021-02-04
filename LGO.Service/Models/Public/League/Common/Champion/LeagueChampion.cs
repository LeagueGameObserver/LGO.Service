using System;
using System.IO;

namespace LGO.Service.Models.Public.League.Common.Champion
{
    public record LeagueChampion
    {
        public Guid Id { get; init; } = Guid.Empty;

        public string Name { get; init; } = string.Empty;

        public FileInfo? TileImage { get; init; }

        public FileInfo? SplashImage { get; init; }

        public FileInfo? LoadingImage { get; init; }

        public static LeagueChampion Null => new();
    }
}