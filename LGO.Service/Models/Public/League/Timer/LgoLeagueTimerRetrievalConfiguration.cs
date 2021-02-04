using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LgoLeagueTimerRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueTimer;

        public bool IncludeGameStartTimeInSeconds { get; init; } = true;

        public bool IncludeGameEndTimeInSeconds { get; init; } = true;

        public static LgoLeagueTimerRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueTimerRetrievalConfiguration IncludeNothing => new()
                                                                             {
                                                                                 IncludeGameStartTimeInSeconds = false,
                                                                                 IncludeGameEndTimeInSeconds = false,
                                                                             };
    }
}