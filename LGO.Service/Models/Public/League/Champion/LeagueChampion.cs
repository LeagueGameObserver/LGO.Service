using System;
using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Champion
{
    [JsonConverter(typeof(LeagueChampionJsonConverter))]
    public record LeagueChampion
    {
        [JsonProperty("Id")]
        public Guid Id { get; init; } = Guid.Empty;

        [JsonProperty("Name")]
        public string Name { get; init; } = string.Empty;

        [JsonProperty("TileImage")]
        public string PathToTileImage { get; init; } = string.Empty;

        [JsonProperty("SplashImage")]
        public string PathToSplashImage { get; init; } = string.Empty;

        [JsonProperty("LoadingImage")]
        public string PathToLoadingImage { get; init; } = string.Empty;

        public static LeagueChampion Null => new();
    }
}