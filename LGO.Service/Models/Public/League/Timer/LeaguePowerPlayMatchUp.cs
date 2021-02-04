namespace LGO.Service.Models.Public.League.Timer
{
    public record LeaguePowerPlayMatchUp
    {
        public LeagueMatchUp MatchUp { get; init; } = LeagueMatchUp.Null;

        public int GoldDifferenceIncrease { get; init; }

        public static LeaguePowerPlayMatchUp Null => new();
    }
}