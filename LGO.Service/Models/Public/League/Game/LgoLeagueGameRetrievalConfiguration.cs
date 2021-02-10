using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Game
{
    public record LgoLeagueGameRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeagueGameRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueGame;

        public bool IncludeGameTimeInSeconds { get; init; } = true;
        
        public bool IncludeMode { get; init; } = true;
        
        public bool IncludeTeams { get; init; } = true;

        public bool IncludePlayers { get; init; } = true;

        public bool IncludeMatchUps { get; init; } = true;

        public bool IncludeTimers { get; init; } = true;

        public bool IncludeEvents { get; init; } = true;

        public bool IncludeEventsSinceLastUpdate { get; init; } = true;

        public static LgoLeagueGameRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueGameRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeGameTimeInSeconds = false,
                                                                                IncludeMode = false,
                                                                                IncludeTeams = false,
                                                                                IncludePlayers = false,
                                                                                IncludeMatchUps = false,
                                                                                IncludeTimers = false,
                                                                                IncludeEvents = false,
                                                                                IncludeEventsSinceLastUpdate = false,
                                                                            };

        internal static LgoLeagueGameRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }
        
        internal static LgoLeagueGameRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeagueGameRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}