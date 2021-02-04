namespace LGO.Service.Models.Public.League.Common.Timer
{
    public record LeaguePowerPlayMatchUp
    {
        public LeagueMatchUp MatchUp { get; init; } = LeagueMatchUp.Null;

        public int GoldDifferenceIncrease { get; init; }

        public static LeaguePowerPlayMatchUp Null => new();
    }
}