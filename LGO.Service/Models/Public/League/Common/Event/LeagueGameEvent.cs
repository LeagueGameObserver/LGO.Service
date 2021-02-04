using LGO.Service.Models.Public.League.Common.Enum;

namespace LGO.Service.Models.Public.League.Common.Event
{
    public abstract record LeagueGameEvent
    {
        public abstract LeagueGameEventType Type { get; }
        
        public double GameTimeInSeconds { get; init; }
    }
}