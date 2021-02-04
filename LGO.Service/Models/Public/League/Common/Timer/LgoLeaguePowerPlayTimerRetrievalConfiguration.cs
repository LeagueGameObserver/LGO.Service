namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LgoLeaguePowerPlayTimerRetrievalConfiguration : LgoLeagueTimerRetrievalConfiguration
    {
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
    }
}