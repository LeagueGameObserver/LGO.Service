using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Team
{
    public record LgoLeagueTeamRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        internal const string RequestExecutionContextPropertyName = nameof(LgoLeagueTeamRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueTeam;

        public bool IncludeSide { get; init; } = true;
        
        public bool IncludeDragonsKilled { get; init; } = true;

        public bool IncludeNumberOfRiftHeraldsKilled { get; init; } = true;

        public bool IncludeNumberOfBaronNashorsKilled { get; init; } = true;

        public bool IncludeTurretsDestroyed { get; init; } = true;

        public bool IncludeInhibitorsDestroyed { get; init; } = true;

        public static LgoLeagueTeamRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueTeamRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeSide = false,
                                                                                IncludeDragonsKilled = false,
                                                                                IncludeNumberOfRiftHeraldsKilled = false,
                                                                                IncludeNumberOfBaronNashorsKilled = false,
                                                                                IncludeTurretsDestroyed = false,
                                                                                IncludeInhibitorsDestroyed = false,
                                                                            };
        
        internal static LgoLeagueTeamRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }

        internal static LgoLeagueTeamRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeagueTeamRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}