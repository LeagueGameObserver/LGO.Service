using LGO.Service.Models.Internal;
using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LgoLeaguePowerPlayTimerRetrievalConfiguration : LgoLeagueTimerRetrievalConfiguration
    {
        internal new const string RequestExecutionContextPropertyName = nameof(LgoLeaguePowerPlayTimerRetrievalConfiguration);
        
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeaguePowerPlayTimer;

        public bool IncludeIsActive { get; init; } = true;

        public bool IncludeMatchUps { get; init; } = true;

        public new static LgoLeaguePowerPlayTimerRetrievalConfiguration IncludeEverything => new();

        public new static LgoLeaguePowerPlayTimerRetrievalConfiguration IncludeNothing => new()
                                                                                          {
                                                                                              IncludeGameStartTimeInSeconds = false,
                                                                                              IncludeGameEndTimeInSeconds = false,
                                                                                              IncludeIsActive = false,
                                                                                              IncludeMatchUps = false,
                                                                                          };

        internal new static LgoLeaguePowerPlayTimerRetrievalConfiguration GetCurrentOrDefault()
        {
            return GetOrDefaultFromContext(RequestExecutionContext.GetCurrentOrDefault());
        }
        
        internal new static LgoLeaguePowerPlayTimerRetrievalConfiguration GetOrDefaultFromContext(RequestExecutionContext context)
        {
            if (context.TryGetProperty<LgoLeaguePowerPlayTimerRetrievalConfiguration>(RequestExecutionContextPropertyName, out var configuration))
            {
                return configuration;
            }

            return IncludeEverything;
        }
    }
}