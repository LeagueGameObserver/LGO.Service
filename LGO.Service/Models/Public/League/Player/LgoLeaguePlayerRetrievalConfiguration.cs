using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Player
{
    public record LgoLeaguePlayerRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeaguePlayerRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeaguePlayer;

        public bool IncludeSummonerName { get; init; } = true;
        
        public bool IncludeTeam { get; init; } = true;

        public bool IncludeChampion { get; init; } = true;

        public bool IncludeItems { get; init; } = true;

        public static LgoLeaguePlayerRetrievalConfiguration IncludeEverything => new();

        public static LgoLeaguePlayerRetrievalConfiguration IncludeNothing => new()
                                                                              {
                                                                                  IncludeSummonerName = false,
                                                                                  IncludeTeam = false,
                                                                                  IncludeChampion = false,
                                                                                  IncludeItems = false,
                                                                              };
        
        internal static LgoLeaguePlayerRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }

        internal static LgoLeaguePlayerRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeaguePlayerRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}