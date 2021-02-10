using System;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Item
{
    [JsonConverter(typeof(LeagueItemJsonConverter))]
    public record LeagueItem
    {
        [JsonProperty("Id")]
        public Guid Id { get; init; } = Guid.Empty;

        [JsonProperty("Name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("Price")]
        public int Price { get; init; }

        [JsonProperty("Image")]
        public string PathToImage { get; init; } = string.Empty;

        public static LeagueItem Null => new();
    }
}