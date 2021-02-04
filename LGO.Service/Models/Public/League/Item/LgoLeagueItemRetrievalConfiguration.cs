using LGO.Service.Models.Public.Enum;

namespace LGO.Service.Models.Public.League.Item
{
    public record LgoLeagueItemRetrievalConfiguration : LgoDataRetrievalConfiguration
    {
        public override LgoDataRetrievalConfigurationType Type => LgoDataRetrievalConfigurationType.LeagueItem;

        public bool IncludeName { get; init; } = true;

        public bool IncludePrice { get; init; } = true;

        public bool IncludeImage { get; init; } = true;

        public static LgoLeagueItemRetrievalConfiguration IncludeEverything => new();

        public static LgoLeagueItemRetrievalConfiguration IncludeNothing => new()
                                                                            {
                                                                                IncludeName = false,
                                                                                IncludePrice = false,
                                                                                IncludeImage = false,
                                                                            };
    }
}