using Newtonsoft.Json;

namespace LGO.Service.Models.Public.League.Timer
{
    public record LeaguePowerPlayMatchUp
    {
        [JsonProperty("MatchUp")]
        public LeagueMatchUp MatchUp { get; init; } = LeagueMatchUp.Null;

        [JsonProperty("GoldDifferenceIncrease")]
        public int GoldDifferenceIncrease { get; init; }

        public static LeaguePowerPlayMatchUp Null => new();
    }
}