namespace LGO.Service.Models.Public.League.Common.Player
{
    public record LgoLeaguePlayerRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeaguePlayer;

        public bool IncludeTeam { get; init; } = true;

        public bool IncludeChampion { get; init; } = true;

        public bool IncludeItems { get; init; } = true;

        public static LgoLeaguePlayerRetrievalConfiguration IncludeEverything => new();

        public static LgoLeaguePlayerRetrievalConfiguration IncludeNothing => new()
                                                                              {
                                                                                  IncludeTeam = false,
                                                                                  IncludeChampion = false,
                                                                                  IncludeItems = false,
                                                                              };
    }
}