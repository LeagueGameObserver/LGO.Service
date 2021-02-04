using System;
using System.IO;

namespace LGO.Service.Models.Public.League.Common.Item
{
    public record LeagueItem
    {
        public Guid Id { get; init; } = Guid.Empty;

        public string Name { get; init; } = string.Empty;
        
        public int Price { get; init; }
        
        public FileInfo? Image { get; init; }

        public static LeagueItem Null => new();
    }
}