namespace LGO.Service.Models.Public.League.Common.Game
{
    public record LgoLeagueGameRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueGame;

        public bool IncludeTeams { get; init; } = true;

        public bool IncludePlayers { get; init; } = true;

        public bool IncludeMatchUps { get; init; } = true;

        public bool IncludeTimers { get; init; } = true;

        public bool IncludeEvents { get; init; } = true;

        public bool IncludeEventsSinceLastUpdate { get; init; } = true;

        public static LgoLeagueGameRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueGameRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeTeams = false,
                                                                                IncludePlayers = false,
                                                                                IncludeMatchUps = false,
                                                                                IncludeTimers = false,
                                                                                IncludeEvents = false,
                                                                                IncludeEventsSinceLastUpdate = false,
                                                                            };
    }
}