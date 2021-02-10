using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Champion
{
    public record LgoLeagueChampionRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeagueChampionRetrievalConfiguration);
        
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

        internal static LgoLeagueChampionRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }

        internal static LgoLeagueChampionRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeagueChampionRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}