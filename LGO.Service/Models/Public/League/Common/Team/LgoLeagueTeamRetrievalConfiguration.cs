namespace LGO.Service.Models.Public.League.Common.Team
{
    public record LgoLeagueTeamRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueTeam;

        public bool IncludeDragonsKilled { get; init; } = true;

        public bool IncludeNumberOfRiftHeraldsKilled { get; init; } = true;

        public bool IncludeNumberOfBaronNashorsKilled { get; init; } = true;

        public bool IncludeTurretsDestroyed { get; init; } = true;

        public bool IncludeInhibitorsDestroyed { get; init; } = true;

        public static LgoLeagueTeamRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueTeamRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeDragonsKilled = false,
                                                                                IncludeNumberOfRiftHeraldsKilled = false,
                                                                                IncludeNumberOfBaronNashorsKilled = false,
                                                                                IncludeTurretsDestroyed = false,
                                                                                IncludeInhibitorsDestroyed = false,
                                                                            };
    }
}