using LGO.Service.Models.Public.League.Enum;

namespace LGO.Service.Models.Public.League.Event
{
    public abstract record LeagueGameEvent
    {
        public abstract LeagueGameEventType Type { get; }
        
        public double GameTimeInSeconds { get; init; }
    }
}