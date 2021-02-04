using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Champion
{
    public record LgoLeagueChampionRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueChampion;

        public bool IncludeName { get; init; } = true;

        public bool IncludeTileImage { get; init; } = true;

        public bool IncludeSplashImage { get; init; } = true;

        public bool IncludeLoadingImage { get; init; } = true;

        public static LgoLeagueChampionRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueChampionRetrievalConfiguration IncludeNothing => new()
                                                                                {
                                                                                    IncludeName = false,
                                                                                    IncludeTileImage = false,
                                                                                    IncludeSplashImage = false,
                                                                                    IncludeLoadingImage = false,
                                                                                };
    }
}