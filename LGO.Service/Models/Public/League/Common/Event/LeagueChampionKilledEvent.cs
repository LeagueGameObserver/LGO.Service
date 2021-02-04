using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public record LeagueChampionKilledEvent : LeagueKillerWithAssistersGameEvent
    {
        public override LeagueGameEventType Type => LeagueGameEventType.ChampionKilled;

        public string VictimSummonerName { get; init; } = string.Empty;

        public static LeagueChampionKilledEvent Null => new();
    }
}