using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LgoLeagueTimerRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeagueTimerRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueTimer;

        public bool IncludeGameStartTimeInSeconds { get; init; } = true;

        public bool IncludeGameEndTimeInSeconds { get; init; } = true;

        public static LgoLeagueTimerRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueTimerRetrievalConfiguration IncludeNothing => new()
                                                                             {
                                                                                 IncludeGameStartTimeInSeconds = false,
                                                                                 IncludeGameEndTimeInSeconds = false,
                                                                             };

        internal static LgoLeagueTimerRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }
        
        internal static LgoLeagueTimerRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeagueTimerRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}