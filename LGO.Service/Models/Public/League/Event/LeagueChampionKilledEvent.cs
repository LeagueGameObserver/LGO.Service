using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public record LeagueChampionKilledEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.ChampionKilled;

        public string VictimSummonerName { get; init; } = string.Empty;

        public static LeagueChampionKilledEvent Null => new();
    }
}