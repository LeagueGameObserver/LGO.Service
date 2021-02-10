using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Item
{
    public record LgoLeagueItemRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeagueItemRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueItem;

        public bool IncludeName { get; init; } = true;

        public bool IncludePrice { get; init; } = true;

        public bool IncludeImage { get; init; } = true;

        public static LgoLeagueItemRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueItemRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeName = false,
                                                                                IncludePrice = false,
                                                                                IncludeImage = false,
                                                                            };

        internal static LgoLeagueItemRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }
        
        internal static LgoLeagueItemRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeagueItemRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}